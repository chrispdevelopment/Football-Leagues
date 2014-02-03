using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Football_Leagues
{
    public partial class frmEditLeague : Form
    {
        public frmEditLeague()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmEditLeague_Load(object sender, EventArgs e)
        {
            lblLeagName.Text = Utilities.currentLeag.getLeagName();
            txtLeagSponsor.Text = Utilities.currentLeag.getLeagSponsor();
            txtLeagPrize.Text = Utilities.currentLeag.getLeagPrize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;
            
            //Get inputs
            string tempSponsor = txtLeagSponsor.Text;
            string tempPrize = txtLeagPrize.Text;

            //Final validation check
            allInputOK = Utilities.notNullTextBox(txtLeagSponsor, "the league sponsor")
                         && Utilities.notNullTextBox(txtLeagPrize, "the league prize");

            //Edit league if all ok
            if (allInputOK)
            {
                //Update current League
                Utilities.currentLeag.setLeagSponsor(tempSponsor);
                Utilities.currentLeag.setLeagPrize(tempPrize);

                //Put updated leagues into all leagues list
                frmHome.allLeagues[frmHome.currentLeagKey] = Utilities.currentLeag;

                //Update all league link lists
                Utilities.createLeagListLinks(ref frmHome.allLeagues, false);

                //Update file
                Utilities.writeAllLeagData(frmHome.inputFootballDataFile, frmHome.allLeagues);

                //Finish up
                MessageBox.Show(Utilities.currentLeag.getLeagName() + " league was edited successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblLeagName.Text = Utilities.currentLeag.getLeagName();
            txtLeagSponsor.Text = Utilities.currentLeag.getLeagSponsor();
            txtLeagPrize.Text = Utilities.currentLeag.getLeagPrize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close and dispose of current form
            this.Close();
            this.Dispose();
        }

        private void frmEditLeague_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome.frmkeepLeagues.Enabled = true;
            frmHome.frmkeepLeagues.Focus(); //Bring home form to front
            frmHome.frmkeepLeagues.updateLeagFormData(); //Update any data changes on home form
        }
    }
}
