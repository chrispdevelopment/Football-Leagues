using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;

namespace Football_Leagues
{
    class Team : IComparable
    {
        //Varible declaration
        private string name;
        private string league;
        private string manager;
        private string nickname;
        private string stadium;
        private int position;
        private int points;
        private int gamesPlayed;
        private int goalDifference;
        private string logo;
        private int teamSize;
        Team next;
        Team previous;

        //Constructors
        public Team(string theName, string theLeague, string theManager, string theNickname,
                    string theStadium, string thePosition, string thePoints, string theGamesPlayed,
                    string theGoalDifference, string theLogo, string theTeamSize)
        {
            name = theName;
            league = theLeague;
            manager = theManager;
            nickname = theNickname;
            stadium = theStadium;
            setPosition(thePosition);
            setPoints(thePoints);
            setGamesPlayed(theGamesPlayed);
            setGoalDifference(theGoalDifference);
            logo = theLogo;
            setTeamSize(theTeamSize);
        }

        //Methods
        public int CompareTo(object obj)
        {
            Team Compare = (Team)obj;
            int result = this.league.CompareTo(Compare.league);
            if (result == 0)
                result = this.position.CompareTo(Compare.position);
            return result;
        }

        //Setters
        public void setName(string inName)
        {
            name = inName;
        }

        public void setLeague(string inLeague)
        {
            league = inLeague;
        }

        public void setManager(string inManager)
        {
            manager = inManager;
        }

        public void setNickname(string inNickname)
        {
            nickname = inNickname;
        }

        public void setStadium(string inStadium)
        {
            stadium = inStadium;
        }

        public void setPosition(string inPostion)
        {
            try
            {
                position = Convert.ToInt32(inPostion);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inPostion +
                        "ERROR:" + e.Message + " Invalid postion was input");
            }
        }

        public void setPoints(string inPoints)
        {
            try
            {
                points = Convert.ToInt32(inPoints);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inPoints +
                        "ERROR:" + e.Message + " Invalid number of points was input");
            }
        }

        public void setGamesPlayed(string inGamesPlayed)
        {
            try
            {
                gamesPlayed = Convert.ToInt32(inGamesPlayed);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inGamesPlayed +
                        "ERROR:" + e.Message + " Invalid number of games played was input");
            }
        }

        public void setGoalDifference(string inGoalDifference)
        {
            try
            {
                goalDifference = Convert.ToInt32(inGoalDifference);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inGoalDifference +
                        "ERROR:" + e.Message + " Invalid goal difference was input");
            }
        }

        public void setLogo(string inLogo)
        {
            logo = inLogo;
        }

        public void setTeamSize(string inTeamSize)
        {
            try
            {
                teamSize = Convert.ToInt32(inTeamSize);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inTeamSize +
                        "ERROR:" + e.Message + " Invalid team size was input");
            }
        }

        public void setNextTeam(Team inNext)
        {
            next = inNext;
        }

        public void setPrevTeam(Team inPrevious)
        {
            previous = inPrevious;
        }

        //Getters
        public string getName()
        {
            return name;
        }

        public string getLeague()
        {
            return league;
        }

        public string getManager()
        {
            return manager;
        }

        public string getNickname()
        {
            return nickname;
        }

        public string getStadium()
        {
            return stadium;
        }

        public int getPosition()
        {
            return position;
        }

        public int getPoints()
        {
            return points;
        }

        public int getGamesPlayed()
        {
            return gamesPlayed;
        }

        public int getGoalDifference()
        {
            return goalDifference;
        }

        public string getLogo()
        {
            return logo;
        }

        public int getTeamSize()
        {
            return teamSize;
        }

        public Team getNextTeam()
        {
            return next;
        }

        public Team getPrevTeam()
        {
            return previous;
        }
    }
}
