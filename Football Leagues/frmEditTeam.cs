using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Football_Leagues
{
    public partial class frmEditTeam : Form
    {
        private string[] logoFileName;
        private string fullFileName;

        public frmEditTeam()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmEditTeam_Load(object sender, EventArgs e)
        {
            txtName.Text = Utilities.currentTeam.getName();
            txtManager.Text = Utilities.currentTeam.getManager();
            txtNickname.Text = Utilities.currentTeam.getNickname();
            txtStadium.Text = Utilities.currentTeam.getStadium();
            txtNoPlayers.Text = Utilities.currentTeam.getTeamSize().ToString();
            picTeamLogo.Image = Utilities.getLogo(Utilities.currentTeam.getLogo());

            foreach (League l in frmHome.allLeagues)
            {
                comboLeag.Items.Add(l.getLeagName());
            }

            foreach (string item in comboLeag.Items)
            {
                if (Utilities.currentTeam.getLeague() == item)
                {
                    comboLeag.SelectedItem = item;
                }
            }
        }

        private void btnChangeLogo_Click(object sender, EventArgs e)
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

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;

            //Get inputs
            string name = txtName.Text;
            string league = comboLeag.SelectedItem.ToString();
            string manager = txtManager.Text;
            string nickname = txtNickname.Text;
            string stadium = txtStadium.Text;
            string teamSize = txtNoPlayers.Text;

            //Final validation check
            allInputOK = Utilities.notNullTextBox(txtName, "the name ")
                         && Utilities.notNullTextBox(txtManager, "the manager ")
                         && Utilities.notNullTextBox(txtNickname, "the nickname ")
                         && Utilities.notNullTextBox(txtStadium, "the stadium ")
                         && Utilities.validNumber(txtNoPlayers, "the number of players ");

            //Edit fixture if all ok
            if (allInputOK)
            {
                //Update current League
                Utilities.currentTeam.setName(name);
                Utilities.currentTeam.setLeague(league);
                Utilities.currentTeam.setManager(manager);
                Utilities.currentTeam.setNickname(nickname);
                Utilities.currentTeam.setStadium(stadium);
                Utilities.currentTeam.setTeamSize(teamSize);

                //Put updated leagues into all leagues list
                frmHome.allTeams[frmHome.currentTeamKey] = Utilities.currentTeam;

                //Update all league link lists
                Utilities.createTeamListLinks(ref frmHome.allTeams);

                //Update file
                Utilities.writeAllTeamData(frmHome.inputTeamDataFile, frmHome.allTeams);

                //Update logo if a new one has been selected
                if (fullFileName != null)
                {
                    Utilities.addLogotoFolder(fullFileName, Utilities.currentTeam.getLogo());
                }

                //Finish up
                MessageBox.Show(Utilities.currentTeam.getName() + " was edited successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = Utilities.currentTeam.getName();
            txtManager.Text = Utilities.currentTeam.getManager();
            txtNickname.Text = Utilities.currentTeam.getNickname();
            txtStadium.Text = Utilities.currentTeam.getStadium();
            txtNoPlayers.Text = Utilities.currentTeam.getTeamSize().ToString();
            picTeamLogo.Image = Utilities.getLogo(Utilities.currentTeam.getLogo());

            foreach (string item in comboLeag.Items)
            {
                if (Utilities.currentTeam.getLeague() == item)
                {
                    comboLeag.SelectedItem = item;
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
            frmHome.frmkeepLeagues.updateTeamFormData(); //Update any data changes on home form
        }
    }
}
