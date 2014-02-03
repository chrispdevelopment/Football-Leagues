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
    public partial class frmProcResults : Form
    {
        public frmProcResults()
        {
            this.Icon = Properties.Resources.footballLogo; //Set form icon
            InitializeComponent();
        }

        private void frmProcResults_Load(object sender, EventArgs e)
        {
            lblTeamNames.Text = Utilities.currentFixture.getHomeTeam() + " V " 
                                + Utilities.currentFixture.getAwayTeam();

            lblHome.Text = Utilities.currentFixture.getHomeTeam() + " Goals";
            lblAway.Text = Utilities.currentFixture.getAwayTeam() + " Goals";
        }

        private void btnProcResults_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;

            //Get inputs
            int homeGoals = Convert.ToInt32(txtHome.Text);
            int awayGoals = Convert.ToInt32(txtAway.Text);

            //Final validation check
            allInputOK = Utilities.notNullTextBox(txtHome, "home goals ")
                         && Utilities.notNullTextBox(txtAway, "away goals ");

            //Process results if all ok
            if (allInputOK)
            {
                foreach (Team t in frmHome.allTeams)
                {
                    if (Utilities.currentFixture.getHomeTeam() == t.getName())
                    {
                        if (homeGoals > awayGoals)
                        {
                            t.setPoints((t.getPoints() + 3).ToString());
                            t.setGoalDifference((t.getGoalDifference() + (homeGoals - awayGoals)).ToString());
                            t.setGamesPlayed((t.getGamesPlayed() + 1).ToString());
                        }
                        else
                        {
                            t.setGoalDifference((t.getGoalDifference() + (homeGoals - awayGoals)).ToString());
                            t.setGamesPlayed((t.getGamesPlayed() + 1).ToString());
                        }

                        foreach (Team teamHome in frmHome.allTeams)
                        {
                            if (teamHome.getName() != t.getName())
                            {
                                if (t.getLeague() == teamHome.getLeague())
                                {
                                    if (t.getPoints() > teamHome.getPoints())
                                    {
                                        if (teamHome.getPosition() == 1)
                                        {
                                            t.setPosition("1");
                                            if (teamHome.getPosition() >= t.getPosition())
                                            {
                                                teamHome.setPosition((teamHome.getPosition() + 1).ToString());
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            t.setPosition((teamHome.getPosition() - 1).ToString());
                                            if (teamHome.getPosition() >= t.getPosition())
                                            {
                                                teamHome.setPosition((teamHome.getPosition() + 1).ToString());
                                            }
                                            break;
                                        }
                                    }
                                    else if (t.getPoints() == teamHome.getPoints())
                                    {
                                        if (t.getGoalDifference() > teamHome.getGoalDifference())
                                        {
                                            if (teamHome.getPosition() == 1)
                                            {
                                                t.setPosition("1");
                                                if (teamHome.getPosition() >= t.getPosition())
                                                {
                                                    teamHome.setPosition((teamHome.getPosition() + 1).ToString());
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                t.setPosition((teamHome.getPosition() - 1).ToString());
                                                if (teamHome.getPosition() >= t.getPosition())
                                                {
                                                    teamHome.setPosition((teamHome.getPosition() + 1).ToString());
                                                }
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            t.setPosition((teamHome.getPosition() + 1).ToString());
                                            if (teamHome.getPosition() >= t.getPosition())
                                            {
                                                teamHome.setPosition((teamHome.getPosition() + 1).ToString());
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Utilities.currentFixture.getAwayTeam() == t.getName())
                    {
                        if (awayGoals > homeGoals)
                        {
                            t.setPoints((t.getPoints() + 3).ToString());
                            t.setGoalDifference((t.getGoalDifference() + (awayGoals - homeGoals)).ToString());
                            t.setGamesPlayed((t.getGamesPlayed() + 1).ToString());
                        }
                        else
                        {
                            t.setGoalDifference((t.getGoalDifference() + (awayGoals - homeGoals)).ToString());
                            t.setGamesPlayed((t.getGamesPlayed() + 1).ToString());
                        }

                        foreach (Team teamAway in frmHome.allTeams)
                        {
                            if (teamAway.getName() != t.getName())
                            {
                                if (t.getLeague() == teamAway.getLeague())
                                {
                                    if (t.getPoints() > teamAway.getPoints())
                                    {
                                        if (teamAway.getPosition() == 1)
                                        {
                                            t.setPosition("1");
                                            if (teamAway.getPosition() >= t.getPosition())
                                            {
                                                teamAway.setPosition((teamAway.getPosition() + 1).ToString());
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            t.setPosition((teamAway.getPosition() - 1).ToString());
                                            if (teamAway.getPosition() >= t.getPosition())
                                            {
                                                teamAway.setPosition((teamAway.getPosition() + 1).ToString());
                                            }
                                            break;
                                        }
                                    }
                                    else if (t.getPoints() == teamAway.getPoints())
                                    {
                                        if (t.getGoalDifference() > teamAway.getGoalDifference())
                                        {
                                            if (teamAway.getPosition() == 1)
                                            {
                                                t.setPosition("1");
                                                if (teamAway.getPosition() >= t.getPosition())
                                                {
                                                    teamAway.setPosition((teamAway.getPosition() + 1).ToString());
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                t.setPosition((teamAway.getPosition() - 1).ToString());
                                                if (teamAway.getPosition() >= t.getPosition())
                                                {
                                                    teamAway.setPosition((teamAway.getPosition() + 1).ToString());
                                                }
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            t.setPosition((teamAway.getPosition() + 1).ToString());
                                            if (teamAway.getPosition() >= t.getPosition())
                                            {
                                                teamAway.setPosition((teamAway.getPosition() + 1).ToString());
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            frmHome.allTeams.Sort();

            Utilities.createTeamListLinks(ref frmHome.allTeams);

            Utilities.currentFixture.setFixProcessed(true.ToString());

            Utilities.currentTeam = (Team)frmHome.allTeams[frmHome.currentTeamKey];

            //Finish up
            MessageBox.Show(Utilities.currentFixture.getHomeTeam() + " V " 
                                + Utilities.currentFixture.getAwayTeam() + " fixture was processed successfully!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHome.Text = "";
            txtAway.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close and dispose of current form
            this.Close();
            this.Dispose();
        }

        private void frmProcResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome.frmkeepLeagues.Enabled = true;
            frmHome.frmkeepLeagues.Focus(); //Bring home form to front
            frmHome.frmkeepLeagues.updateTeamFormData(); //Update any data changes on home form
        }
    }
}
