using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Football_Leagues
{
    public partial class frmAddFixture : Form
    {
        public frmAddFixture()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmAddFixture_Load(object sender, EventArgs e)
        {
            foreach (Team t in frmHome.allTeams)
            {
                comboLocation.Items.Add(t.getStadium());
                comboHome.Items.Add(t.getName());
                comboAway.Items.Add(t.getName());
            }

            comboLocation.SelectedIndex = 0;
            comboHome.SelectedIndex = 0;
            comboAway.SelectedIndex = 0;
        }

        private void btnAddFix_Click(object sender, EventArgs e)
        {
            ArrayList fixtures;
            bool allInputOK = false;

            //Get inputs
            DateTime tempDate = dateFixDate.Value;
            string tempTime = txtFixTime.Text;
            string tempLocation = comboLocation.SelectedText;
            string tempHome = comboHome.SelectedText;
            string tempAway = comboHome.SelectedText;
            string tempFixProc = "False";

            //Final validation check
            allInputOK = Utilities.validDate(dateFixDate, "add", "this fixture")
                         && Utilities.notNullTextBox(txtFixTime, "the time");

            //Create fixture if all ok
            if (allInputOK)
            {
                //Create fixture
                Fixture tempFix = new Fixture(tempDate.ToString("dd/MM/yy"), tempTime, 
                                              tempLocation, tempHome, tempAway, tempFixProc);

                //Add new fixture to the current league object
                Utilities.currentLeag.addFixtureToLeague(Utilities.currentLeag.getLeagFixtures(), tempFix);

                //Sort the current league fixture list
                Utilities.currentLeag.getLeagFixtures().Sort();

                //Update current league fixture list links
                Utilities.createFixListLinks(Utilities.currentLeag.getLeagFixtures());

                //Update current fixture to equal temporay fixture
                Utilities.currentFixture = tempFix;

                //Find new fixture key & set current fixture
                Utilities.findObjectKey(Utilities.currentLeag.getLeagFixtures(), "Fixture", "Date");
                fixtures = Utilities.currentLeag.getLeagFixtures();
                Utilities.currentFixture = (Fixture)fixtures[frmHome.currentFixKey];

                //Update all leagues data with new league data
                frmHome.allLeagues[frmHome.currentLeagKey] = Utilities.currentLeag;

                //Update file
                Utilities.writeAllLeagData(frmHome.inputFootballDataFile, frmHome.allLeagues);

                //Finish up
                MessageBox.Show(tempFix.getHomeTeam() + " V " + tempFix.getAwayTeam() + " fixture was added successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateFixDate.Value = DateTime.Today;
            txtFixTime.Text = "";
            comboLocation.SelectedIndex = 0;
            comboHome.SelectedIndex = 0;
            comboAway.SelectedIndex = 0;
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
            frmHome.frmkeepLeagues.updateFixFormData(); //Update any data changes on home form
        }
    }
}
