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
    public partial class frmEditFixture : Form
    {
        public frmEditFixture()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmEditFixture_Load(object sender, EventArgs e)
        {
            dateFixDate.Value = Utilities.currentFixture.getDate();
            txtFixTime.Text = Utilities.currentFixture.getTime();

            foreach (Team t in frmHome.allTeams)
            {
                comboLocation.Items.Add(t.getStadium());
                comboHome.Items.Add(t.getName());
                comboAway.Items.Add(t.getName());
            }

            foreach (string item in comboLocation.Items)
            {
                if (Utilities.currentFixture.getLocation() == item)
                {
                    comboLocation.SelectedItem = item;
                }
            }

            foreach (string item in comboHome.Items)
            {
                if (Utilities.currentFixture.getHomeTeam() == item)
                {
                    comboHome.SelectedItem = item;
                }
            }

            foreach (string item in comboAway.Items)
            {
                if (Utilities.currentFixture.getAwayTeam() == item)
                {
                    comboAway.SelectedItem = item;
                }
            }
        }

        private void btnEditFix_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;
            ArrayList fixtures;

            //Get inputs
            DateTime tempDate = dateFixDate.Value;
            string tempTime = txtFixTime.Text;
            string tempLoc = comboLocation.SelectedText;
            string tempHome = comboHome.SelectedText;
            string tempAway = comboAway.SelectedText;

            //Final validation check
            allInputOK = Utilities.validDate(dateFixDate, "add", "this fixture")
                         && Utilities.notNullTextBox(txtFixTime, "the time");

            //Edit Fixture if all ok
            if (allInputOK)
            {
                //Update current Fixture
                Utilities.currentFixture.setDate(tempDate.ToString("dd/MM/yy"));
                Utilities.currentFixture.setTime(tempTime);
                Utilities.currentFixture.setLocation(tempLoc);
                Utilities.currentFixture.setHomeTeam(tempHome);
                Utilities.currentFixture.setAwayTeam(tempAway);

                //Update fixture in current league data
                Utilities.currentLeag.replaceFixture(Utilities.currentLeag.getLeagFixtures(), 
                                                     Utilities.currentFixture, frmHome.currentFixKey);

                //Sort the current league fixture list
                Utilities.currentLeag.getLeagFixtures().Sort();

                //Update current league fixture list links
                Utilities.createFixListLinks(Utilities.currentLeag.getLeagFixtures());

                //Find current fixture key
                Utilities.findObjectKey(Utilities.currentLeag.getLeagFixtures(), "Fixture", "Date");
                fixtures = Utilities.currentLeag.getLeagFixtures();
                Utilities.currentFixture = (Fixture)fixtures[frmHome.currentFixKey];

                //Put updated leagues into all leagues list
                frmHome.allLeagues[frmHome.currentLeagKey] = Utilities.currentLeag;

                //Update file
                Utilities.writeAllLeagData(frmHome.inputFootballDataFile, frmHome.allLeagues);

                //Finish up
                MessageBox.Show(Utilities.currentFixture.getHomeTeam() + " V " + Utilities.currentFixture.getAwayTeam() + " fixture was edited successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateFixDate.Value = Utilities.currentFixture.getDate();
            txtFixTime.Text = Utilities.currentFixture.getTime();

            foreach (string item in comboLocation.Items)
            {
                if (Utilities.currentFixture.getLocation() == item)
                {
                    comboLocation.SelectedItem = item;
                }
            }

            foreach (string item in comboHome.Items)
            {
                if (Utilities.currentFixture.getHomeTeam() == item)
                {
                    comboHome.SelectedItem = item;
                }
            }

            foreach (string item in comboAway.Items)
            {
                if (Utilities.currentFixture.getAwayTeam() == item)
                {
                    comboAway.SelectedItem = item;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close and dispose of current form
            this.Close();
            this.Dispose();
        }

        private void frmEditFixture_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome.frmkeepLeagues.Enabled = true;
            frmHome.frmkeepLeagues.Focus(); //Bring home form to front
            frmHome.frmkeepLeagues.updateFixFormData(); //Update any data changes on home form
        }
    }
}
