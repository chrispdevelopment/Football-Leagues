using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Leagues
{
    class Fixture : IComparable
    {
        //Varible declaration
        private DateTime date;
        private string time;
        private string location;
        private string homeTeam;
        private string awayTeam;
        private bool fixtureProcessed;
        Fixture previous;
        Fixture next;

        //Constructors
        //Fixture Order = Date -> Time -> Location -> Home Team -> Away Team -> Fixture Processed
        public Fixture(string theDate,string theTime, string theLocation,
                       string theHomeTeam, string theAwayTeam, string theFixProcessed)
        {
            setDate(theDate);
            time = theTime;
            location = theLocation;
            homeTeam = theHomeTeam;
            awayTeam = theAwayTeam;
            setFixProcessed(theFixProcessed);
        }//end constructor

        //Methods
        public int CompareTo(object obj)
        {
            Fixture Compare = (Fixture)obj;
            int result = this.date.CompareTo(Compare.date);
            if (result == 0)
                result = this.time.CompareTo(Compare.time);
            return result;
        }

        //Setters
        public void setDate(string inDate)
        {
            date = DateTime.Parse(inDate);
        }

        public void setTime(string inTime)
        {
            time = inTime;
        }

        public void setLocation(string inLocation)
        {
            location = inLocation;
        }

        public void setHomeTeam(string inHomeTeam)
        {
            homeTeam = inHomeTeam;
        }

        public void setAwayTeam(string inAwayTeam)
        {
            awayTeam = inAwayTeam;
        }

        public void setFixProcessed(string inFixProc)
        {
            try
            {
                fixtureProcessed = Convert.ToBoolean(inFixProc);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show(inFixProc +
                        "ERROR:" + e.Message + " Invalid state entered, must be true or false");
            }
        }

        public void setPrevious(Fixture inPrevious)
        {
            previous = inPrevious;
        }

        public void setNext(Fixture inNext)
        {
            next = inNext;
        }

        //Getters
        public DateTime getDate()
        {
            return date.Date;
        }

        public string getTime()
        {
            return time;
        }

        public string getLocation()
        {
            return location;
        }

        public string getHomeTeam()
        {
            return homeTeam;
        }

        public string getAwayTeam()
        {
            return awayTeam;
        }

        public bool getFixProcessed()
        {
            return fixtureProcessed;
        }

        public Fixture getPrevious()
        {
            return previous;
        }

        public Fixture getNext()
        {
            return next;
        }
    }
}
