using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Football_Leagues
{
    public partial class frmSearch : Form
    {
        ArrayList searchItems = new ArrayList();

        public frmSearch()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            comboSearchType.SelectedIndex = 0;

            pnlFixtures.Hide();
            pnlTeams.Hide();
        }

        private void comboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchType.SelectedIndex == 0)
            {
                pnlLeagues.Show();
                pnlFixtures.Hide();
                pnlTeams.Hide();
            }
            else if (comboSearchType.SelectedIndex == 1)
            {
                pnlLeagues.Hide();
                pnlFixtures.Show();
                pnlTeams.Hide();

                dateFixDate.Hide();
            }
            else
            {
                pnlLeagues.Hide();
                pnlFixtures.Hide();
                pnlTeams.Show();
            }
        }

        private void comboPropFix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPropFix.SelectedIndex == 0)
            {
                txtStringFix.Hide();
                dateFixDate.Show();
            }
            else
            {
                txtStringFix.Show();
                dateFixDate.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string output;
            bool inputOk = false;

            if (comboSearchType.SelectedIndex == 0)
            {
                searchItems.Clear();
                lstResultsLeag.Items.Clear();

                //Final Validation
                inputOk = Utilities.notNullTextBox(txtStringLeag, "the entered string");

                //If search parameter is a number check to see if its valid
                if (comboPropLeag.SelectedItem.ToString() == "No of Fixtures")
                {
                    inputOk = Utilities.validNumber(txtStringLeag, "the number entered ");
                }

                if (inputOk)
                {
                    foreach (League l in frmHome.allLeagues)
                    {
                        switch (comboPropLeag.SelectedItem.ToString())
                        {
                            case ("Name"):
                                if (Utilities.stringCompare(l.getLeagName(), txtStringLeag.Text))
                                {
                                    searchItems.Add(l);
                                    output = l.getLeagName();
                                    lstResultsLeag.Items.Add(output);
                                }
                                break;
                            case ("Sponsor"):
                                if (Utilities.stringCompare(l.getLeagSponsor(), txtStringLeag.Text))
                                {
                                    searchItems.Add(l);
                                    output = l.getLeagName();
                                    lstResultsLeag.Items.Add(output);
                                }
                                break;
                            case ("Prize"):
                                if (Utilities.stringCompare(l.getLeagPrize(), txtStringLeag.Text))
                                {
                                    searchItems.Add(l);
                                    output = l.getLeagName();
                                    lstResultsLeag.Items.Add(output);
                                }
                                break;
                            case ("No of Fixtures"):

                                if (l.getLeagNumFixtures() == Convert.ToInt32(txtStringLeag.Text))
                                {
                                    searchItems.Add(l);
                                    output = l.getLeagName();
                                    lstResultsLeag.Items.Add(output);
                                }
                                break;
                        }
                    }
                }

                if (searchItems.Count < 1)
                {
                    lstResultsLeag.Items.Clear();
                    output = "No search results found";
                    lstResultsLeag.Items.Add(output);
                }
            }
            else if (comboSearchType.SelectedIndex == 1)
            {
                searchItems.Clear();
                lstResultsFix.Items.Clear();

                //Final Validation
                if (comboPropFix.SelectedItem.ToString() != "Date")
                {
                    inputOk = Utilities.notNullTextBox(txtStringFix, "the entered string");
                }
                else
                {
                    inputOk = true;
                }

                if (inputOk)
                {
                    foreach (League l in frmHome.allLeagues)
                    {
                        foreach (Fixture f in l.getLeagFixtures())
                        {
                            switch (comboPropFix.SelectedItem.ToString())
                            {
                                case ("Date"):
                                    if (f.getDate().Date == dateFixDate.Value.Date)
                                    {
                                        searchItems.Add(l);
                                        searchItems.Add(f);
                                        output = f.getHomeTeam() + " V " + f.getAwayTeam();
                                        lstResultsFix.Items.Add(output);
                                    }
                                    break;
                                case ("Time"):
                                    if (Utilities.stringCompare(f.getTime(), txtStringFix.Text))
                                    {
                                        searchItems.Add(l);
                                        searchItems.Add(f);
                                        output = f.getHomeTeam() + " V " + f.getAwayTeam();
                                        lstResultsFix.Items.Add(output);
                                    }
                                    break;
                                case ("Location"):
                                    if (Utilities.stringCompare(f.getLocation(), txtStringFix.Text))
                                    {
                                        searchItems.Add(l);
                                        searchItems.Add(f);
                                        output = f.getHomeTeam() + " V " + f.getAwayTeam();
                                        lstResultsFix.Items.Add(output);
                                    }
                                    break;
                                case ("Home Team"):
                                    if (Utilities.stringCompare(f.getHomeTeam(), txtStringFix.Text))
                                    {
                                        searchItems.Add(l);
                                        searchItems.Add(f);
                                        output = f.getHomeTeam() + " V " + f.getAwayTeam();
                                        lstResultsFix.Items.Add(output);
                                    }
                                    break;
                                case ("Away Team"):
                                    if (Utilities.stringCompare(f.getAwayTeam(), txtStringFix.Text))
                                    {
                                        searchItems.Add(l);
                                        searchItems.Add(f);
                                        output = f.getHomeTeam() + " V " + f.getAwayTeam();
                                        lstResultsFix.Items.Add(output);
                                    }
                                    break;
                            }
                        }
                    }
                }

                if (searchItems.Count < 1)
                {
                    lstResultsFix.Items.Clear();
                    output = "No search results found";
                    lstResultsFix.Items.Add(output);
                }
            }
            else if (comboSearchType.SelectedIndex == 2)
            {
                searchItems.Clear();
                lstResultsTeam.Items.Clear();

                //Final Validation
                inputOk = Utilities.notNullTextBox(txtStringTeam, "the entered string");

                //If search parameter is a number check to see if its valid
                if (comboPropTeam.SelectedItem.ToString() == "Position" 
                    || comboPropTeam.SelectedItem.ToString() == "Points"
                    || comboPropTeam.SelectedItem.ToString() == "Games Played"
                    || comboPropTeam.SelectedItem.ToString() == "Goal Difference"
                    || comboPropTeam.SelectedItem.ToString() == "Team Size")
                {
                    inputOk = Utilities.validNumber(txtStringLeag, "the number entered ");
                }

                if (inputOk)
                {
                    foreach (Team t in frmHome.allTeams)
                    {
                        switch (comboPropTeam.SelectedItem.ToString())
                        {
                            case ("Name"):
                                if (Utilities.stringCompare(t.getName(), txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getName();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("League"):
                                if (Utilities.stringCompare(t.getLeague(), txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getLeague();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Manager"):
                                if (Utilities.stringCompare(t.getManager(), txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getManager();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Nickname"):
                                if (Utilities.stringCompare(t.getNickname(), txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getNickname();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Stadium"):
                                if (Utilities.stringCompare(t.getStadium(), txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getStadium();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Position"):
                                if (t.getPosition() == Convert.ToInt32(txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getName();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Points"):
                                if (t.getPoints() == Convert.ToInt32(txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getName();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Games Played"):
                                if (t.getGamesPlayed() == Convert.ToInt32(txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getName();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Goal Difference"):
                                if (t.getGoalDifference() == Convert.ToInt32(txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getName();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                            case ("Team Size"):
                                if (t.getTeamSize() == Convert.ToInt32(txtStringTeam.Text))
                                {
                                    searchItems.Add(t);
                                    output = t.getName();
                                    lstResultsTeam.Items.Add(output);
                                }
                                break;
                        }
                    }
                }
            }

            if (searchItems.Count < 1)
            {
                lstResultsTeam.Items.Clear();
                output = "No search results found";
                lstResultsTeam.Items.Add(output);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (comboSearchType.SelectedIndex == 0)
            {
                Utilities.currentLeag = (League)searchItems[lstResultsLeag.SelectedIndex];
                frmHome.frmkeepLeagues.updateLeagFormData();
                frmHome.frmkeepLeagues.tabPages.SelectedTab = frmHome.frmkeepLeagues.tabLeagues;
            }
            else if (comboSearchType.SelectedIndex == 1)
            {
                int selectedIndex = lstResultsFix.SelectedIndex * 2;

                Utilities.currentLeag = (League)searchItems[selectedIndex];
                frmHome.frmkeepLeagues.updateLeagFormData();
                Utilities.currentFixture = (Fixture)searchItems[selectedIndex + 1];
                frmHome.frmkeepLeagues.updateFixFormData();
                frmHome.frmkeepLeagues.tabPages.SelectedTab = frmHome.frmkeepLeagues.tabLeagues;
            }
            else
            {
                Utilities.currentTeam = (Team)searchItems[lstResultsTeam.SelectedIndex];
                frmHome.frmkeepLeagues.updateTeamFormData();
                frmHome.frmkeepLeagues.tabPages.SelectedTab = frmHome.frmkeepLeagues.tabTeams;
            }

            //Close and dispose of current form
            this.Close();
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (comboSearchType.SelectedIndex == 0)
            {
                txtStringLeag.Text = "";
                comboPropLeag.SelectedIndex = 0;
                lstResultsLeag.Items.Clear();
            }
            else if (comboSearchType.SelectedIndex == 1)
            {
                txtStringFix.Text = "";
                comboPropFix.SelectedIndex = 0;
                lstResultsFix.Items.Clear();
            }
            else
            {
                txtStringTeam.Text = "";
                comboPropTeam.SelectedIndex = 0;
                lstResultsTeam.Items.Clear();
            }
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
        }
    }
}
