using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Leagues
{
    class League
    {
        //Varible declaration
        private string leagName;
        private string leagSponsor;
        private string leagPrize;
        private int leagNumFixtures;
        ArrayList leagFixtures;
        League previous;
        League next;

        //Constructors
        public League(string theLeagName, string theLeagSponsor, 
                      string theLeagPrize, string theLeagNumFixtures)
        {
            leagName = theLeagName;
            leagSponsor = theLeagSponsor;
            leagPrize = theLeagPrize;
            setLeagNumFixtures(theLeagNumFixtures);
            leagFixtures = new ArrayList();
        }

        //Methods
        //Add fixture to league
        public ArrayList addFixtureToLeague(ArrayList theFixturesSoFar, Fixture theNewFixture)
        {
            theFixturesSoFar.Add(theNewFixture);
            leagNumFixtures = theFixturesSoFar.Count;
            return theFixturesSoFar;
        }

        //Replace fixture in league
        public ArrayList replaceFixture(ArrayList theFixtures, Fixture newVersion, int location)
        {
            theFixtures[location] = newVersion;
            return theFixtures;
        }

        //Delete fixture from league
        public ArrayList deleteFixture(ArrayList theFixtures)
        {
            theFixtures.RemoveAt(frmHome.currentFixKey);
            leagNumFixtures = theFixtures.Count;
            return theFixtures;
        }

        //Setters
        public void setLeagName(string inLeagName)
        {
            leagName = inLeagName;
        }

        public void setLeagSponsor(string inLeagSponsor)
        {
            leagSponsor = inLeagSponsor;
        }

        public void setLeagPrize(string inLeagPrice)
        {
            leagPrize = inLeagPrice;
        }

        public void setLeagNumFixtures(string inLeagNumFixtures)
        {
            try
            {
                leagNumFixtures = Convert.ToInt32(inLeagNumFixtures);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inLeagNumFixtures +
                        "ERROR:" + e.Message + " Invalid number of fixtures was input");
            }
        }

        public void setLeagFixtures(ArrayList inLeagFixtures)
        {
            leagFixtures = inLeagFixtures;
        }

        public void setPreviousLeag(League inPrevious)
        {
            previous = inPrevious;
        }

        public void setNextLeag(League inNext)
        {
            next = inNext;
        }

        //Getters

        public string getLeagName()
        {
            return leagName;
        }

        public string getLeagSponsor()
        {
            return leagSponsor;
        }

        public string getLeagPrize()
        {
            return leagPrize;
        }

        public int getLeagNumFixtures()
        {
            return leagNumFixtures;
        }

        public ArrayList getLeagFixtures()
        {
            return leagFixtures;
        }

        public League getPreviousLeag()
        {
            return previous;
        }

        public League getNextLeag()
        {
            return next;
        }
    }
}
