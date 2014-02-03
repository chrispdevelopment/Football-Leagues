using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Resources;

namespace Football_Leagues
{
    public partial class frmHome : Form
    {
        //Varible declaration
        public static frmHome frmkeepLeagues = null; //Need reference to call form back again
        public static ArrayList allLeagues = new ArrayList(); // Need access from other forms
        public static ArrayList allTeams = new ArrayList(); // Need access from other forms
        public static int currentLeagKey = 0;
        public static int currentFixKey = 0;
        public static int currentTeamKey = 0;
        public static string inputFootballDataFile = Path.GetFullPath("Resources/football.txt");
        public static string inputTeamDataFile = Path.GetFullPath("Resources/teams.txt");
        public static int numFixtureItems = 6;
        public static int numLeagueItems = 4;
        public static int numTeamItems = 11;

        public frmHome()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
            frmkeepLeagues = this;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Read league and team data into array lists then add link lists
            Utilities.readLeagues(inputFootballDataFile, ref allLeagues);
            Utilities.readTeams(inputTeamDataFile, ref allTeams);
        }

        //Form methods
        //Update league form data when update have occured to the league data from another form
        public void updateLeagFormData()
        {
            //Show current league data in leagues tab
            Utilities.showCurrentLeag(lblLeagName, lblLeagSponsor, lblLeagPrize, lblLeageFixNo,
                                          lblFixDate, lblFixTime, lblFixLocation, lblHomeName, lblAwayName,
                                          picLogoHome, picLogoAway);

            checkForFixtuers();
            checkButtonState();
        }

        //Update form fixture data when a change has occured to the fixture data from another form
        public void updateFixFormData()
        {
            lblLeageFixNo.Text = Utilities.currentLeag.getLeagNumFixtures().ToString();
            Utilities.showCurrentFixture(lblFixDate, lblFixTime, lblFixLocation,
                                         lblHomeName, lblAwayName, picLogoHome, picLogoAway);

            checkForFixtuers();
            checkButtonState();
        }

        public void updateTeamFormData()
        {
            Utilities.showCurrentTeam(lblTeamName, lblTeamLeague, lblTeamManager, lblTeamNickname,
                                      lblTeamStadium, lblTeamPostion, lblTeamPoints, lblTeamGamesPlayed,
                                      lblTeamGoalDiff, picTeamLogo, lblTeamNoPlayers);
        }

        //Show or hide fixtures panel depending on whether league has fixtures
        private void checkForFixtuers()
        {
            if (Utilities.currentLeag.getLeagFixtures().Count > 0)
            {
                pnlNoFix.Hide();
                pnlFixtures.Show();
            }
            else
            {
                pnlFixtures.Hide();
                pnlNoFix.Show();
            }
        }

        //Check to see if edit and delete button should be active or not
        private void checkButtonState()
        {
            if (Utilities.currentFixture != null)
            {
                if ((Utilities.currentFixture.getDate() - DateTime.Now).TotalDays < 7)
                {
                    btnEditFix.Enabled = false;
                }
                else
                {
                    btnEditFix.Enabled = true;
                }

                if ((Utilities.currentFixture.getDate() - DateTime.Now).TotalDays < 1)
                {
                    btnDelFix.Enabled = false;
                }
                else
                {
                    btnDelFix.Enabled = true;
                }
            }
        }

        //Form event procedures
        private void btnPrevLeag_Click(object sender, EventArgs e)
        {
            Utilities.showLeagues(lblLeagName, lblLeagSponsor, lblLeagPrize, lblLeageFixNo, 
                                  lblFixDate, lblFixTime, lblFixLocation, lblHomeName, lblAwayName, 
                                  picLogoHome, picLogoAway, "back");

            //Show or hide fixtures panel depending on whether league has fixtures
            checkForFixtuers();
            checkButtonState();
        }

        private void btnNextLeag_Click(object sender, EventArgs e)
        {
            Utilities.showLeagues(lblLeagName, lblLeagSponsor, lblLeagPrize, lblLeageFixNo, 
                                  lblFixDate, lblFixTime, lblFixLocation, lblHomeName, lblAwayName, 
                                  picLogoHome, picLogoAway, "forward");

            //Show or hide fixtures panel depending on whether league has fixtures
            checkForFixtuers();
            checkButtonState();
        }

        private void btnEditLeag_Click(object sender, EventArgs e)
        {
            frmEditLeague tempEditLeague = new frmEditLeague();
            this.Enabled = false;
            tempEditLeague.Show();
        }

        private void btnPrevFix_Click(object sender, EventArgs e)
        {
            Utilities.showFixtures(lblFixDate, lblFixTime, lblFixLocation, lblHomeName, 
                                  lblAwayName, picLogoHome, picLogoAway, "back");

            checkButtonState();
        }

        private void btnNextFix_Click(object sender, EventArgs e)
        {
            Utilities.showFixtures(lblFixDate, lblFixTime, lblFixLocation, lblHomeName, 
                                  lblAwayName, picLogoHome, picLogoAway, "forward");

            checkButtonState();
        }

        private void btnAddFixture_Click(object sender, EventArgs e)
        {
            frmAddFixture tempAddFixture = new frmAddFixture();
            this.Enabled = false;
            tempAddFixture.Show();
        }

        private void btnAddFixture2_Click(object sender, EventArgs e)
        {
            frmAddFixture tempAddFixture = new frmAddFixture();
            this.Enabled = false;
            tempAddFixture.Show();
        }

        private void btnEditFix_Click(object sender, EventArgs e)
        {
            frmEditFixture tempEditFixture = new frmEditFixture();
            this.Enabled = false;
            tempEditFixture.Show();
        }

        private void btnDelFix_Click(object sender, EventArgs e)
        {
            DialogResult deleteMessage = MessageBox.Show("Do you wish to delete this fixture", Utilities.currentFixture.getHomeTeam() + 
                                                         " V " + Utilities.currentFixture.getAwayTeam(), MessageBoxButtons.YesNo);
            if (deleteMessage == DialogResult.Yes)
            {
                Utilities.deleteFixture();
                if (Utilities.currentLeag.getLeagFixtures().Count > 0)
                {
                    lblLeageFixNo.Text = Utilities.currentLeag.getLeagNumFixtures().ToString();
                    Utilities.showCurrentFixture(lblFixDate, lblFixTime, lblFixLocation,
                                                 lblHomeName, lblAwayName, picLogoHome, picLogoAway);
                }
                else
                {
                    lblLeageFixNo.Text = Utilities.currentLeag.getLeagNumFixtures().ToString();
                    checkForFixtuers();
                }
            }
        }

        private void btnProcResults_Click(object sender, EventArgs e)
        {
            if (Utilities.currentFixture.getFixProcessed() == false)
            {
                frmProcResults tempProcResults = new frmProcResults();
                this.Enabled = false;
                tempProcResults.Show();
            }
            else
            {
                MessageBox.Show("This fixture has already been processed");
            }
        }

        private void btnPrevTeam_Click(object sender, EventArgs e)
        {
            Utilities.showTeams(lblTeamName, lblTeamLeague, lblTeamManager, lblTeamNickname,
                                lblTeamStadium, lblTeamPostion, lblTeamPoints, lblTeamGamesPlayed,
                                lblTeamGoalDiff, picTeamLogo, lblTeamNoPlayers, "back");
        }

        private void btnNextTeam_Click(object sender, EventArgs e)
        {
            Utilities.showTeams(lblTeamName, lblTeamLeague, lblTeamManager, lblTeamNickname,
                                lblTeamStadium, lblTeamPostion, lblTeamPoints, lblTeamGamesPlayed,
                                lblTeamGoalDiff, picTeamLogo, lblTeamNoPlayers, "forward");
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam tempAddTeam = new frmAddTeam();
            this.Enabled = false;
            tempAddTeam.Show();
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            frmEditTeam tempEditTeam = new frmEditTeam();
            this.Enabled = false;
            tempEditTeam.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch tempSearch = new frmSearch();
            this.Enabled = false;
            tempSearch.Show();
        }

        private void tabLeagues_Selected(object sender, EventArgs e)
        {
            //Show current league data in leagues tab
            Utilities.showCurrentLeag(lblLeagName, lblLeagSponsor, lblLeagPrize, lblLeageFixNo,
                                          lblFixDate, lblFixTime, lblFixLocation, lblHomeName, lblAwayName,
                                          picLogoHome, picLogoAway);

            //Show or hide fixtures panel depending on whether league has fixtures
            checkForFixtuers();
        }

        private void tabTeams_Selected(object sender, EventArgs e)
        {
            //Show current team in the teams tab
            Utilities.showCurrentTeam(lblTeamName, lblTeamLeague, lblTeamManager, lblTeamNickname, 
                                      lblTeamStadium, lblTeamPostion, lblTeamPoints, lblTeamGamesPlayed, 
                                      lblTeamGoalDiff, picTeamLogo, lblTeamNoPlayers);
        }
    }
}
