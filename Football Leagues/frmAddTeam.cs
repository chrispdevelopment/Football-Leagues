using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace Football_Leagues
{
    public partial class frmAddTeam : Form
    {
        private string[] logoFileName;
        private string fullFileName;

        public frmAddTeam()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {
            foreach (League l in frmHome.allLeagues)
            {
                comboLeag.Items.Add(l.getLeagName());
            }

            comboLeag.SelectedIndex = 0;
        }

        private void btnSelectLogo_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = diagLogo.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                fullFileName = diagLogo.FileName;
                logoFileName = diagLogo.SafeFileName.Split('.');
                
                if (logoFileName[1] == "png")
                {
                    picTeamLogo.Image = new Bitmap(fullFileName);
                }
                else
                {
                    MessageBox.Show("File selected is not a PNG please reselect");
                }
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;

            //Get inputs
            string name = txtName.Text;
            string league = comboLeag.SelectedItem.ToString();
            string manager = txtManager.Text;
            string nickname = txtNickname.Text;
            string stadium = txtStadium.Text;
            string position = txtPosition.Text;
            string points = txtPoints.Text;
            string gamesPlayed = txtGamesPlayed.Text;
            string goalDifference = txtGoalDiff.Text;
            string teamSize = txtNoPlayers.Text;

            //Final validation check
            allInputOK = Utilities.notNullTextBox(txtName, "the name ")
                         && Utilities.notNullTextBox(txtManager, "the manager ")
                         && Utilities.notNullTextBox(txtNickname, "the nickname ")
                         && Utilities.notNullTextBox(txtStadium, "the stadium ")
                         && Utilities.validNumber(txtPosition, "the position ")
                         && Utilities.validNumber(txtPoints, "the points ")
                         && Utilities.validNumber(txtGamesPlayed, "the games played ")
                         && Utilities.validNumber(txtGoalDiff, "the goal difference ")
                         && Utilities.validNumber(txtNoPlayers, "the number of players ")
                         && Utilities.logoSelected(fullFileName);

            //Create fixture if all ok
            if (allInputOK)
            {
                //Create Team
                Team tempTeam = new Team(name, league, manager, nickname, stadium, position,
                                         points, gamesPlayed, goalDifference,
                                         string.Join(".", logoFileName), teamSize);

                //Update postions of teams within the all teams league
                foreach (Team t in frmHome.allTeams)
                {
                    if (t.getLeague() == tempTeam.getLeague())
                    {
                        if (t.getPosition() >= tempTeam.getPosition())
                        {
                            t.setPosition((t.getPosition() + 1).ToString());
                        }
                    }
                }

                //Add new team to the all team array
                frmHome.allTeams.Add(tempTeam);

                //Sort the all team array
                frmHome.allTeams.Sort();

                //Update all teams link lists
                Utilities.createTeamListLinks(ref frmHome.allTeams);

                //Update current team to equal tempory team
                Utilities.currentTeam = tempTeam;

                //Find new team key & set current team
                Utilities.findObjectKey(frmHome.allTeams, "Team", "Name");
                Utilities.currentTeam = (Team)frmHome.allTeams[frmHome.currentTeamKey];

                //Update all team data with new team data
                frmHome.allTeams[frmHome.currentTeamKey] = Utilities.currentTeam;

                //Update file
                Utilities.writeAllTeamData(frmHome.inputTeamDataFile, frmHome.allTeams);

                //Add logo to logo folder
                Utilities.addLogotoFolder(fullFileName, tempTeam.getLogo());

                //Finish up
                MessageBox.Show(tempTeam.getName() + " was added successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtManager.Text = "";
            txtNickname.Text = "";
            txtStadium.Text = "";
            txtNoPlayers.Text = "";
            txtPosition.Text = "";
            txtPoints.Text = "";
            txtGamesPlayed.Text = "";
            txtGoalDiff.Text = "";
            picTeamLogo.Image = Properties.Resources.noLogo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close and dispose of current form
            this.Close();
            this.Dispose();
        }

        private void frmAddFixture_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome.frmkeepLeagues.Enabled = true;
            frmHome.frmkeepLeagues.Focus(); //Bring home form to front
            frmHome.frmkeepLeagues.updateTeamFormData(); //Update any data changes on home form
        }
    }
}
