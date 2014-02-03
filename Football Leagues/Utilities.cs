using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Resources;
using System.Drawing;

namespace Football_Leagues
{
    class Utilities
    {
        //Public varible declaration
        public static Fixture currentFixture;
        public static League currentLeag;
        public static Team currentTeam;

        //Read in league data
        public static void readLeagues(string theFile, ref ArrayList allLeagues)
        {
            //Local variables
            StreamReader inLeagues = null;
            bool anyMoreFixtures = false;
            string[] leagData = new string[frmHome.numLeagueItems];
            string[] fixtureData = new string[frmHome.numFixtureItems];
            League tempLeag;
            Fixture tempFixture;
            int numFixturesinLeag;

            //If file opened ok proceed
            if (Utilities.fileOpenForReadOK(theFile, ref inLeagues))
            {
                //Read first league of fixtures
                anyMoreFixtures = Utilities.getNext(frmHome.numLeagueItems, inLeagues, leagData);

                //Loop for all Leagues in file
                while (anyMoreFixtures == true)
                {
                    numFixturesinLeag = Convert.ToInt32(leagData[3]); //last item is num of fixtures in league

                    //ORDER = Name, Sponsor, Prize, Number of fixtures in league
                    tempLeag = new League(leagData[0], leagData[1], leagData[2], Convert.ToString(numFixturesinLeag));
                    
                    //READ all fixtures into league
                    for (int i = 0; i < numFixturesinLeag; i++)
                    {
                        //Get next fixture in league
                        getNext(frmHome.numFixtureItems, inLeagues, fixtureData);
                        
                        //Order = Date, Time, Location, Home Team, Away Team, Fixture Processed
                        tempFixture = new Fixture(fixtureData[0], fixtureData[1], fixtureData[2], fixtureData[3], fixtureData[4], fixtureData[5]);

                        //Add fixture to league data
                        tempLeag.addFixtureToLeague(tempLeag.getLeagFixtures(), tempFixture);
                    }

                    //Sort fixtures
                    tempLeag.getLeagFixtures().Sort();

                    //Add league (incl all its fixtuers) into the data structure
                    allLeagues.Add(tempLeag);

                    //Create link lists
                    createLeagListLinks(ref allLeagues, true);

                    //Check for any more fixtuers
                    anyMoreFixtures = getNext(frmHome.numLeagueItems, inLeagues, leagData);
                }
            }
            //Finish/tidy up
            if (inLeagues != null) inLeagues.Close();
            //allLeagues.Sort();
        }//End read leagues

        //Read in team data
        public static void readTeams(string theFile, ref ArrayList allTeams)
        {
            //Local variables
            StreamReader inTeams = null;
            bool anyMoreTeams = false;
            string[] teamData = new string[frmHome.numTeamItems];
            Team tempTeam;
            
            //Ff file opened ok proceed
            if (Utilities.fileOpenForReadOK(theFile, ref inTeams))
            {
                //Read first team
                anyMoreTeams = Utilities.getNext(frmHome.numTeamItems, inTeams, teamData);

                //Loop for all Teams in file
                while (anyMoreTeams == true)
                {
                    //ORDER = Name, League, Manager, Nickname, Stadium, Postion, Points, Games Played, 
                    //Goal Difference, Logo, Team Size
                    tempTeam = new Team(teamData[0], teamData[1], teamData[2], teamData[3], teamData[4], 
                                        teamData[5], teamData[6], teamData[7], teamData[8], teamData[9],
                                        teamData[10]);

                    //Add Team into the data structure
                    allTeams.Add(tempTeam);

                    //Sort all teams array
                    allTeams.Sort();

                    //Create link lists
                    createTeamListLinks(ref allTeams);

                    //Check to see if there are any more teams
                    anyMoreTeams = getNext(frmHome.numTeamItems, inTeams, teamData);
                }
            }
            //Finish/tidy up
            if (inTeams != null) inTeams.Close();
        }

        //Create link lists for all leagues & all fixtures
        public static void createLeagListLinks(ref ArrayList theLeagues, bool updateFixtures)
        {
            League leagPool = null;
            
            foreach (League league in theLeagues)
            {
                //Create list links
                league.setPreviousLeag(leagPool);

                //Check to see if league pool is empty
                if (leagPool != null)
                {
                    leagPool.setNextLeag(league);
                }
                else if (currentLeag == null)
                {
                    //Set current league to first league in array
                    currentLeag = league;
                }

                //Set league pool to temp league
                leagPool = league;

                //Create fixture link lists
                if (updateFixtures == true)
                createFixListLinks(league.getLeagFixtures());
            }
        }

        //Create link lists for fixtures
        public static void createFixListLinks(ArrayList theFixtures)
        {
            Fixture fixPool = null;

            foreach (Fixture fixture in theFixtures)
            {
                //Create list links
                fixture.setPrevious(fixPool);

                //Check to see if fixture pool is empty
                if (fixPool != null)
                {
                    fixPool.setNext(fixture);
                }

                //Set fixture pool to temp fixture
                fixPool = fixture;
            }
        }

        //Create link lists for all teams
        public static void createTeamListLinks(ref ArrayList theTeams)
        {
            Team teamPool = null;

            foreach (Team team in theTeams)
            {
                //Create list links
                team.setPrevTeam(teamPool);

                //Check to see if team pool is empty
                if (teamPool != null)
                {
                    teamPool.setNextTeam(team);
                }
                else if (currentTeam == null)
                {
                    //Set current team to first team in array
                    currentTeam = team;
                }

                //Set team pool to current team
                teamPool = team;
            }
        }

        //Write all league data out
        public static void writeAllLeagData(string theFile, ArrayList allLeagues)
        {
            //local variables
            StreamWriter outputLeagues = null;

            //Create out
            if (fileOpenForWriteOK(theFile, ref outputLeagues))
            {
                //loop through each league    
                foreach (League currLeague in allLeagues)
                {
                    writeLeag(outputLeagues, currLeague);
                    //loop through each ficture
                    foreach (Fixture currFix in currLeague.getLeagFixtures())
                    {
                        writeFixture(outputLeagues, currFix);
                    }
                }
                outputLeagues.Close();

                //Finish/tidy up
                if (outputLeagues != null) outputLeagues.Close();
            }
        }

        //Write all team data out
        public static void writeAllTeamData(string theFile, ArrayList allTeams)
        {
            //local variables
            StreamWriter outputTeams = null;

            //Create out
            if (fileOpenForWriteOK(theFile, ref outputTeams))
            {
                //Loop through each team
                foreach (Team currTeam in allTeams)
                {
                    writeTeam(outputTeams, currTeam);
                }
                outputTeams.Close();

                //Finish/tidy up
                if (outputTeams != null) outputTeams.Close();
            }
        }

        //SERVICES
        //Get next data item
        public static bool getNext(int numItems, StreamReader inNext, string[] nextDataPeice)
        {
            //Locals
            string nextLine;
            int numDataItems = numItems;

            //Read data - based on constant numDataItems
            for (int i = 0; i < numDataItems; i++)
            {
                try
                {
                    nextLine = inNext.ReadLine();
                    if (nextLine != null)
                        nextDataPeice[i] = nextLine;
                    else
                    {
                        return false; //No more data items to process 
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR Reading from file. Incomplete Data.\n" 
                                                         + e.Message);
                    return false; //Problem - could not read file
                }
            }
            return true;//No problems 
        }

        //Write league data
        public static void writeLeag(StreamWriter writingOutLeag, League thisLeague)
        {
            //Write out all its details
            writingOutLeag.WriteLine(thisLeague.getLeagName());
            writingOutLeag.WriteLine(thisLeague.getLeagSponsor());
            writingOutLeag.WriteLine(thisLeague.getLeagPrize());
            writingOutLeag.WriteLine(thisLeague.getLeagNumFixtures());
           
        }

        //Write fixture data
        public static void writeFixture(StreamWriter writingOutFixture, Fixture thisFixture)
        {
            //Write out all its details
            writingOutFixture.WriteLine(thisFixture.getDate());
            writingOutFixture.WriteLine(thisFixture.getTime());
            writingOutFixture.WriteLine(thisFixture.getLocation());
            writingOutFixture.WriteLine(thisFixture.getHomeTeam());
            writingOutFixture.WriteLine(thisFixture.getAwayTeam());
            writingOutFixture.WriteLine(thisFixture.getFixProcessed());
        }

        //Write team data
        public static void writeTeam(StreamWriter writingOutTeam, Team thisTeam)
        {
            //Write out all its details
            writingOutTeam.WriteLine(thisTeam.getName());
            writingOutTeam.WriteLine(thisTeam.getLeague());
            writingOutTeam.WriteLine(thisTeam.getManager());
            writingOutTeam.WriteLine(thisTeam.getNickname());
            writingOutTeam.WriteLine(thisTeam.getStadium());
            writingOutTeam.WriteLine(thisTeam.getPosition());
            writingOutTeam.WriteLine(thisTeam.getPoints());
            writingOutTeam.WriteLine(thisTeam.getGamesPlayed());
            writingOutTeam.WriteLine(thisTeam.getGoalDifference());
            writingOutTeam.WriteLine(thisTeam.getLogo());
            writingOutTeam.WriteLine(thisTeam.getTeamSize());
        }

        //Process current league & all its fixture data to be shown on forms
        public static void showCurrentLeag(Label currentName, Label currentSponsor, Label currentPrize, 
                                           Label currentNumFix, Label currentDate, Label currentTime, 
                                           Label currentLocation, Label currentHomeTeam, Label currentAwayTeam
                                           , PictureBox currentHomeLogo, PictureBox currentAwayLogo)
        {
            //Get list of current leagues fixtures
            ArrayList fixtures = currentLeag.getLeagFixtures();

            frmHome.currentFixKey = 0;

            //Pass league data back to calling function
            currentName.Text = currentLeag.getLeagName();
            currentSponsor.Text = currentLeag.getLeagSponsor();
            currentPrize.Text = currentLeag.getLeagPrize();
            currentNumFix.Text = currentLeag.getLeagNumFixtures().ToString();

            //Check that league has fixtuers
            if (currentLeag.getLeagFixtures().Count > 0)
            {
                //Get start of current league fixtures
                currentFixture = (Fixture)fixtures[0];

                //Pass fixture data back to calling function
                showCurrentFixture(currentDate, currentTime, currentLocation, currentHomeTeam,
                                   currentAwayTeam, currentHomeLogo, currentAwayLogo);
            }
        }

        //Process current fixture data
        public static void showCurrentFixture(Label fixDate, Label fixTime,
                                              Label fixLocation, Label fixHomeTeam, Label fixAwayTeam,
                                              PictureBox fixHomeLogo, PictureBox fixAwayLogo)
        {
            if (currentFixture != null)
            {
                //Pass current fixture data back to calling function
                fixDate.Text = currentFixture.getDate().ToString("dd/MM/yy");
                fixTime.Text = currentFixture.getTime();
                fixLocation.Text = currentFixture.getLocation();
                fixHomeTeam.Text = currentFixture.getHomeTeam();
                fixAwayTeam.Text = currentFixture.getAwayTeam();

                //Loop through team data for logos
                foreach (Team away in frmHome.allTeams)
                {
                    if (currentFixture.getAwayTeam() == away.getName())
                    {
                        fixAwayLogo.Image = getLogo(away.getLogo());
                        break;
                    }
                    else
                    {
                        fixAwayLogo.Image = Properties.Resources.noLogo;
                    }
                }

                foreach (Team home in frmHome.allTeams)
                {
                    if (currentFixture.getHomeTeam() == home.getName())
                    {
                        fixHomeLogo.Image = getLogo(home.getLogo());
                        break;
                    }
                    else
                    {
                        fixHomeLogo.Image = Properties.Resources.noLogo;
                    }
                }
            }
        }

        //Process current team data
        public static void showCurrentTeam(Label teamName, Label teamLeague, Label teamManager, 
                                           Label teamNickname, Label teamStadium, Label teamPostion, 
                                           Label teamPoints, Label teamGamesPlayed, 
                                           Label teamGoalDiff, PictureBox teamLogo, Label teamSize)
        {
            //Pass current team data back to calling function
            teamName.Text = currentTeam.getName();
            teamLeague.Text = currentTeam.getLeague();
            teamManager.Text = currentTeam.getManager();
            teamNickname.Text = currentTeam.getNickname();
            teamStadium.Text = currentTeam.getStadium();
            teamPostion.Text = currentTeam.getPosition().ToString();
            teamPoints.Text = currentTeam.getPoints().ToString();
            teamGamesPlayed.Text = currentTeam.getGamesPlayed().ToString();
            teamGoalDiff.Text = currentTeam.getGoalDifference().ToString();
            teamLogo.Image = getLogo(currentTeam.getLogo());
            teamSize.Text = currentTeam.getTeamSize().ToString();
        }

        //Show league data when previous and next buttons are pressed
        public static void showLeagues(Label inName, Label inSponsor, Label inPrize, Label inNumFix, 
                                       Label inDate, Label inTime, Label inLocation, Label inHomeTeam, 
                                       Label inAwayTeam, PictureBox inHomeLogo, PictureBox inAwayLogo, 
                                       string direction)
        {
            //Check to see what direction to proceed in & whether the end of data has been hit
            if (direction == "forward" && currentLeag.getNextLeag() != null)
            {
                currentLeag = currentLeag.getNextLeag(); //move to next node
                frmHome.currentLeagKey += 1;
            }
            else if (direction == "back" && currentLeag.getPreviousLeag() != null)
            {
                currentLeag = currentLeag.getPreviousLeag(); //move to previous node
                frmHome.currentLeagKey -= 1;
            }
            else
            {
                MessageBox.Show("No more leagues"); //No more data - display message
            }

            //Call function to retreive league & fixture information
            showCurrentLeag(inName, inSponsor, inPrize, inNumFix, inDate, inTime, inLocation, 
                            inHomeTeam, inAwayTeam, inHomeLogo, inAwayLogo);
           
        }

        //Show fixture data when previous and next buttons are pressed
        public static void showFixtures(Label inDate, Label inTime, Label inLocation, Label inHomeTeam,
                                       Label inAwayTeam, PictureBox inHomeLogo, PictureBox inAwayLogo, 
                                       string direction)
        {
            //Check to see what direction to proceed in & whether the end of data has been hit
            if (direction == "forward" && currentFixture.getNext() != null)
            {
                currentFixture = currentFixture.getNext(); //Move to next node
                frmHome.currentFixKey += 1;
            }
            else if (direction == "back" && currentFixture.getPrevious() != null)
            {
                currentFixture = currentFixture.getPrevious(); //Move to previous node
                frmHome.currentFixKey -= 1;
            }
            else
            {
                MessageBox.Show("No more fixtures"); //No more data - display message
            }

            //Pass current fixture data back to calling function
            showCurrentFixture(inDate, inTime, inLocation, inHomeTeam, inAwayTeam, inHomeLogo, inAwayLogo);
            
        }

        //Show team data when previous and next buttons are pressed
        public static void showTeams(Label teamName, Label teamLeague, Label teamManager, Label teamNickname,
                                     Label teamStadium, Label teamPostion, Label teamPoints, 
                                     Label teamGamesPlayed, Label teamGoalDiff, PictureBox teamLogo, 
                                     Label teamSize, string direction)
        {
            //Check to see what direction to proceed in & whether the end of data has been hit
            if (direction == "forward" & currentTeam.getNextTeam() != null)
            {
                currentTeam = currentTeam.getNextTeam(); //Move to next node
                frmHome.currentTeamKey += 1;
            }
            else if (direction == "back" & currentTeam.getPrevTeam() != null)
            {
                currentTeam = currentTeam.getPrevTeam(); //Move to previous node
                frmHome.currentTeamKey -= 1;
            }
            else
            {
                MessageBox.Show("No more teams"); //No more data - display message
            }

            //Pass current team data back to calling function
            showCurrentTeam(teamName, teamLeague, teamManager, teamNickname, teamStadium, teamPostion,
                            teamPoints, teamGamesPlayed, teamGoalDiff, teamLogo, teamSize);
        }

        //Delete a fixture from the current league
        public static void deleteFixture()
        {
            ArrayList fixtures;

            //Delete current fixture from current league
            currentLeag.deleteFixture(currentLeag.getLeagFixtures());

            //Update league fixture links
            createFixListLinks(currentLeag.getLeagFixtures());

            //Check to see if current fixture key is out of bounds
            if (frmHome.currentFixKey > currentLeag.getLeagFixtures().Count - 1)
            {
                //Reduce by 1 if it is
                frmHome.currentFixKey -= 1;
            }

            if (currentLeag.getLeagFixtures().Count > 0)
            {
                fixtures = currentLeag.getLeagFixtures();
                currentFixture = (Fixture)fixtures[frmHome.currentFixKey];
            }

            //Write out new league data to league array
            frmHome.allLeagues[frmHome.currentLeagKey] = currentLeag;

            //Write out all league data to file
            writeAllLeagData(frmHome.inputFootballDataFile, frmHome.allLeagues);

            //Finish up
            MessageBox.Show("Fixture was deleted successfully!");
        }

        //Open data file & try to write to it
        public static bool fileOpenForWriteOK(string writeFile, ref StreamWriter dataOut)
        {
            //open file - check for errors            
            try
            {
                dataOut = new StreamWriter(writeFile, false, Encoding.Default);
                return true;
            }
            catch (FileNotFoundException notFound)
            {
                System.Windows.Forms.MessageBox.Show("ERROR Opening file (when writing data out)" +
                                "- File could not be found.\n" + notFound.Message);
                return false;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR Opening File (when writing data out)" +
                                "- Operation failed.\n" + e.Message);
                return false;
            }
        }

        //Open data file & try to read from it
        public static bool fileOpenForReadOK(string readFile, ref StreamReader dataIn)
        {
            //open file - check for errors            
            try
            {
                dataIn = new StreamReader(readFile, Encoding.Default);
                return true;
            }
            catch (FileNotFoundException notFound)
            {
                System.Windows.Forms.MessageBox.Show("ERROR Opening file (when reading data in)" + 
                                                     " - File could not be found.\n"
                                                     + notFound.Message);
                return false;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR Opening File (when reading data in)" + 
                                                     " - Operation failed.\n"
                                                     + e.Message);
                return false;
            }
        }

        //Take selected logo on file add copy it to the logos folder
        public static void addLogotoFolder(string filePath, string logoName)
        {
            try
            {
                System.IO.File.Copy(filePath, Path.GetFullPath("Resources/logos/" + logoName), true);
            }
            catch (FileNotFoundException fileNotFoundError)
            {
                MessageBox.Show("Error - File not found - " + fileNotFoundError.Message);
            }
            catch (IOException copyError)
            {
                MessageBox.Show("Error - File could not be copied - " + copyError);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error - File could not be read - " + e.Message);
            }
        }

        //Attempt to get logo image from file
        public static Bitmap getLogo(string logoFileName)
        {
            Bitmap logoBitmap = null;

            try
            {
                logoBitmap = new Bitmap(Path.GetFullPath("Resources/logos/" + logoFileName));
            }
            catch (FileLoadException fileLoadError)
            {
                MessageBox.Show("Error - Unable to load image - " + fileLoadError.Message);
            }
            catch (FileNotFoundException fileNotFoundError)
            {
                MessageBox.Show("Error - File could not be found - " + fileNotFoundError);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error - File could not be read - " + e.Message);
            }

            return logoBitmap;
        }

        //Search Methods
        //Find and set the keys for current objects
        public static void findObjectKey(ArrayList theObjects, string objectType, string searchCriteria)
        {
            int key = 0;

            if (objectType == "League")
            {
                foreach (League l in theObjects)
                {
                    switch (searchCriteria)
                    {
                        case ("Name"):
                            if (l.getLeagName() == currentLeag.getLeagName())
                            {
                                frmHome.currentLeagKey = key;
                            }
                            break;
                        case ("Sponsor"):
                            if (l.getLeagSponsor() == currentLeag.getLeagSponsor())
                            {
                                frmHome.currentLeagKey = key;
                            }
                            break;
                        case ("Prize"):
                            if (l.getLeagPrize() == currentLeag.getLeagPrize())
                            {
                                frmHome.currentLeagKey = key;
                            }
                            break;
                        case ("No of Fixtures"):
                            if (l.getLeagNumFixtures() == currentLeag.getLeagNumFixtures())
                            {
                                frmHome.currentLeagKey = key;
                            }
                            break;
                    }

                    ++key;
                }
            }
            else if (objectType == "Fixture")
            {
                foreach (Fixture f in theObjects)
                {
                    switch (searchCriteria)
                    {
                        case ("Date"):
                            if (f.getDate() == currentFixture.getDate())
                            {
                                frmHome.currentFixKey = key;
                            }
                            break;
                        case ("Time"):
                            if (f.getTime() == currentFixture.getTime())
                            {
                                frmHome.currentFixKey = key;
                            }
                            break;
                        case ("Location"):
                            if (f.getLocation() == currentFixture.getLocation())
                            {
                                frmHome.currentFixKey = key;
                            }
                            break;
                        case ("Home Team"):
                            if (f.getHomeTeam() == currentFixture.getHomeTeam())
                            {
                                frmHome.currentFixKey = key;
                            }
                            break;
                        case ("Away Team"):
                            if (f.getAwayTeam() == currentFixture.getAwayTeam())
                            {
                                frmHome.currentFixKey = key;
                            }
                            break;
                    }

                    ++key;
                }
            }
            else if (objectType == "Team")
            {
                foreach (Team t in theObjects)
                {
                    switch (searchCriteria)
                    {
                        case ("Name"):
                            if (t.getName() == currentTeam.getName())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("League"):
                            if (t.getLeague() == currentTeam.getLeague())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Manager"):
                            if (t.getManager() == currentTeam.getManager())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Nickname"):
                            if (t.getNickname() == currentTeam.getNickname())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Stadium"):
                            if (t.getStadium() == currentTeam.getStadium())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Position"):
                            if (t.getPosition() == currentTeam.getPosition())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Points"):
                            if (t.getPoints() == currentTeam.getPoints())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Games Played"):
                            if (t.getGamesPlayed() == currentTeam.getGamesPlayed())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Goal Difference"):
                            if (t.getGoalDifference() == currentTeam.getGoalDifference())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                        case ("Team Size"):
                            if (t.getTeamSize() == currentTeam.getTeamSize())
                            {
                                frmHome.currentTeamKey = key;
                            }
                            break;
                    }

                    ++key;
                }
            }
        }

        //Compare a users input string against a data string
        public static bool stringCompare(string stringToCompare, string inputString)
        {
            bool matchFound = false;
            int maxSize, currentPostion = 0, subStringLength = inputString.Length;
            string currentSubString;

            maxSize = stringToCompare.Length;

            if (stringToCompare.Length >= inputString.Length)
            {
                do
                {
                    currentSubString = stringToCompare.Substring(currentPostion, subStringLength);

                    currentPostion += 1;

                    if (currentSubString.ToLower() == inputString.ToLower())
                        matchFound = true;

                } while ((!matchFound) && (currentPostion <= (maxSize - subStringLength)));
            }

            return matchFound;
        }

        //INPUT VALIDAION
        //Check to see if input text boxes are empty
        public static bool notNullTextBox(TextBox txtCurrent, string userFeedback)
        {
            if (txtCurrent.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("ERROR - The input for " + userFeedback +
                                                     " cannot be empty!. Please input again ... ");
                txtCurrent.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //Check to see if entered number is valid
        public static bool validNumber(TextBox txtBeingTested, string outputString)
        {
            try
            {
                Convert.ToInt32(txtBeingTested.Text);
                return true;
            }
            catch (FormatException e)
            {
                MessageBox.Show("INVALID Input: " + e.Message + "The input for " + outputString 
                                + "is not a valid number");
                txtBeingTested.Text = "";
                txtBeingTested.Focus();
                return false;
            }
        }

        //Check to see if date inputted is within allowed date range
        public static bool validDate(DateTimePicker pickBeingTested, string operation, string userFeedback)
        {
            //Perform if data is being added
            if (operation == "add")
            {
                if ((pickBeingTested.Value - DateTime.Now).TotalDays < 7)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR - The date for " + userFeedback + 
                                                         " has to be more then 7 days from today!." 
                                                         + " Please input again ... ");
                    pickBeingTested.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else //Perform if data is being edited
            {
                if ((pickBeingTested.Value - DateTime.Now).TotalDays < 1)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR - The data for " + userFeedback + 
                                                         " has to be more then 1 day from today!." 
                                                         + " Please input again ... ");
                    pickBeingTested.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //Check that a logo has been selected
        public static bool logoSelected(string logoBeingTested)
        {
            if (logoBeingTested == null)
            {
                System.Windows.Forms.MessageBox.Show("ERROR - You must select a logo for this team");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
