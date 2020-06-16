//using FootballManager.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.GamePlayer
{
    public class ProgramUI
    {
        enum Team { Colts = 1, Jaguars }
        enum Position { QB, RB1, RB2, WR1, WR2, TE, DL, LB, DB }

        //private readonly HttpClient _httpClient = new HttpClient();
        //public async Task<Team> GetTeamAsync(string url)
        //{
        //    HttpResponseMessage response = await _httpClient.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        Team teamID = await response.Content.ReadAsAsync<Team>();
        //        return teamID;
        //    }
        //    return null;
        //}
        //public async Task<Team> GetTeamDetailsAsync(string url)
        //{
        //    HttpResponseMessage response = await _httpClient.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        Team teamDetails = await response.Content.ReadAsAsync<Team>();
        //        return teamDetails;
        //    }
        //    return null;
        //}

        bool isGameActive = true;
        int playerOneStartingScore = 0;
        int playerTwoStartingScore = 0;
        int plays = 0;
        int maxPlays = 4;
        int possessions = 0;
        int maxPossessions = 4;

        static string nameKey = "Name";
        static string positionKey = "Position";
        static string ratingKey = "Rating";

        Dictionary<string, int> computerTeamSelection = new Dictionary<string, int>
        {
            { "Colts" , 1 },                                                      // Name of team, and the average off/def "Power"
            { "Jaguars" , 2 },
            { "Texans" , 3 },
            { "Titans" , 4 },
            { "Buccaneers" , 5 },
            { "Falcons" , 6 },
            { "Panthers" , 7 },
            { "Saints" , 8 }
        };

        Dictionary<string, int> coinToss = new Dictionary<string, int>
        {
            {"Heads" , 1 },
            {"Tails" , 2 }
        };

        Dictionary<string, dynamic>[] coltsPlayerArray = new Dictionary<string, dynamic>[]
        {
            new Dictionary<string, dynamic>
            {
                {nameKey, "Philip Rivers"},
                {positionKey, Position.QB},
                {ratingKey, 84}
            },
            new Dictionary<string, dynamic>
            {
                {nameKey, "Marlon Mack"},
                {positionKey, Position.RB1},
                {ratingKey, 85}
            },
            new Dictionary<string, dynamic>
            {
                {nameKey, "Nyheim Hines"},
                {positionKey, Position.RB2},
                {ratingKey, 80}
            },
            new Dictionary<string, dynamic>
            {
                {nameKey, "T.Y. Hilton"},
                {positionKey, Position.WR1},
                {ratingKey, 86}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Zach Pascal"},
                {positionKey, Position.WR2},
                {ratingKey, 77}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Jack Doyle"},
                {positionKey, Position.TE},
                {ratingKey, 81}
            },

            new Dictionary<string, dynamic>
            {
                {nameKey, "DeForest Buckner"},
                {positionKey, Position.DL},
                {ratingKey, 96}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Justin Houston"},
                {positionKey, Position.DL},
                {ratingKey, 88}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Darius Leonard"},
                {positionKey, Position.LB},
                {ratingKey, 96}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Anthony Walker"},
                {positionKey, Position.LB},
                {ratingKey, 84}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Kenny Moore II"},
                {positionKey, Position.DB},
                {ratingKey, 82}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Malik Hooker"},
                {positionKey, Position.DB},
                {ratingKey, 83}
            },
        };

        Dictionary<string, dynamic>[] jaguarsPlayerArray = new Dictionary<string, dynamic>[]
        {
            new Dictionary<string, dynamic>
            {
                {nameKey, "Gardner Minshew II"},
                {positionKey, Position.QB},
                {ratingKey, 81}
            },
            new Dictionary<string, dynamic>
            {
                {nameKey, "Leonard Fournette"},
                {positionKey, Position.RB1},
                {ratingKey, 83}
            },
            new Dictionary<string, dynamic>
            {
                {nameKey, "Chris Thompson"},
                {positionKey, Position.RB2},
                {ratingKey, 75}
            },
            new Dictionary<string, dynamic>
            {
                {nameKey, "D.J. Chark Jr."},
                {positionKey, Position.WR1},
                {ratingKey, 88}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Dede Westbrook"},
                {positionKey, Position.WR2},
                {ratingKey, 76}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Tyler Eifert"},
                {positionKey, Position.TE},
                {ratingKey, 80}
            },

            new Dictionary<string, dynamic>
            {
                {nameKey, "Josh Allen"},
                {positionKey, Position.DL},
                {ratingKey, 90}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Yannick Ngakoue"},
                {positionKey, Position.DL},
                {ratingKey, 94}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Myles Jack"},
                {positionKey, Position.LB},
                {ratingKey, 93}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Joe Schobert"},
                {positionKey, Position.LB},
                {ratingKey, 79}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "CJ Henderson"},
                {positionKey, Position.DB},
                {ratingKey, 80}
            },new Dictionary<string, dynamic>
            {
                {nameKey, "Ronnie harrison"},
                {positionKey, Position.DB},
                {ratingKey, 75}
            },
        };

        Dictionary<string, int> coltsPlayerOverallRating = new Dictionary<string, int>
        {
            {"Philip Rivers"    , 84},
            {"Marlon Mack"      , 85},
            {"Nyheim Hines"     , 80},
            {"T.Y. Hilton"      , 86},
            {"Zach Pascal"      , 77},
            {"Jack Doyle"       , 81},

            {"DeForest Buckner" , 96},
            {"Justin Houston"   , 88},
            {"Darius Leonard"   , 96},
            {"Anthony Walker"   , 84},
            {"Kenny Moore II"   , 82},
            {"Malik Hooker"     , 83}
        };

        public void Run()
        {
            string titlescreen = System.IO.File.ReadAllText(@"C:\Users\13172\Desktop\BlueBadgeProject\FootballManager.GamePlayer\Football Manager Start Screen.txt");
            Console.WriteLine(titlescreen);
            Console.ReadKey();
            RunMenu();
            TeamSelection();
        }

        public void RunMenu()
        {
            {
                Console.Clear();                                                // Clears everything at the start of the screen
                string startGame = "1. Start Game";                             // Creating our three options on our Run Menu
                string viewTeams = "2. View Teams";
                string exitGame = "3. Exit";                                    // The options are to start the game, view teams or exit
                while (isGameActive == true)                                    // We created a while loop so easily end the game later on
                {
                    Console.WriteLine(startGame + "\n" + viewTeams + "\n" + exitGame);
                    string goodBye = "Goodbye, Thanks for Playing!";
                    string selection = Console.ReadLine();                      // Creating this string for our switch cases, also have it equal
                                                                                // to a ReadLine so the user has to select an option to proceed
                    switch (selection)
                    {
                        case "1":
                            TeamSelection();
                            break;
                        case "2":
                            ViewTeams();
                            break;
                        case "3":
                            Console.WriteLine(goodBye);                         // Console App while also saying goodbye, with padding
                            Environment.Exit(0);                                // This line of code closes the console application and avoids crash
                            break;
                        default:                                                // Important to have this default; since we have it set to Run Menu
                            RunMenu();                                          // it basically restarts this page. Without it, if we pressed anything
                            break;                                              // besides our two cases, we would continue to print those two cases,
                    }                                                           // which looks sloppy and broken
                }
            }
        }

        public void TeamSelection()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Football Manager");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Player One, please select your Team!");
            string userChoice = GetUsersChoiceForTeam();
            Team selectedTeam = Team.Colts;
            Team selectedOpponentTeam = Team.Jaguars;

            if (userChoice == "9")
            {
                RunMenu();
            }
            else
            {
                selectedTeam = (Team)Convert.ToInt32(userChoice);
                DisplaySelectedTeam(selectedTeam);
            }
            Console.ReadLine();

            string opponentChoice = OpponentChoice();
            if (opponentChoice == "9")
            {
                RunMenu();
            }
            else
            {
                selectedOpponentTeam = (Team)Convert.ToInt32(opponentChoice);
                DisplaySelectedTeam(selectedOpponentTeam);
            }
            Console.ReadLine();
            Console.WriteLine($"Todays game will be played between {selectedTeam} and {selectedOpponentTeam}");
            Console.ReadLine();
            // Having a reselect team option
            Console.WriteLine("Are you ready to begin?");
            Console.WriteLine("\n1. Yes!\n" + "2. No, return to the main menu!\n");
            string areYouReadyToPlay = Console.ReadLine();

            switch (areYouReadyToPlay)
            {
                case "1":
                    CoinToss();
                    break;
                case "2":
                    RunMenu();
                    break;
                default:
                    break;
            }
        }

        public string OpponentChoice()
        {
            Console.Clear();
            Console.WriteLine("Would you like to select your opponent or have it be selected for you?");
            Console.WriteLine("\n1. Select your opponent!\n" + "2. Select to have a random opponent!\n");
            string doYouWantToPickYourOpponent = Console.ReadLine();

            switch (doYouWantToPickYourOpponent)
            {
                case "1":
                    string playerTwoSelection = OpponentChoiceOne();
                    return playerTwoSelection;
                case "2":
                    string playerTwoRandomSelection = OpponenetChoiceTwo();
                    return playerTwoRandomSelection;
                default:
                    return "9";
            }
        }

        public string OpponentChoiceOne()
        {
            Console.Clear();
            Console.WriteLine("Player Two, please select your Team!");

            string opponentChoice = GetUsersChoiceForTeam();
            return opponentChoice;
        }

        private string OpponenetChoiceTwo()
        {
            Console.Clear();
            string randomTeamSelection = Convert.ToString((int)ComputerTeamSelection());
            Console.WriteLine($"Your opponent will be {randomTeamSelection}!");
            Console.WriteLine($"Here is the starting lineup for the {randomTeamSelection}!");
            return randomTeamSelection;
        }

        public void ViewTeams()
        {
            Console.Clear();

            string viewTeam = GetUsersChoiceForTeam();
            if (viewTeam == "9")
            {
                RunMenu();
            }
            else
            {
                Team selectedTeam = (Team)Convert.ToInt32(viewTeam);
                DisplaySelectedTeam(selectedTeam);
            }
            Console.ReadLine();
            Console.ReadKey();

            ViewTeams();

            // At least 2 methods similar to swapi, to bring in Teams and Team Details from API
        }

        public void CoinToss()
        {
            string coinTossFlip = CoinTossResult(coinToss);
            // Just a 50/50 Coin Toss to determine who gets the ball first
            Console.Clear();
            Console.WriteLine("It's time to do the coin toss, would you like Heads or Tails?");
            Console.WriteLine("\n1. Heads\n" + "2. Tails\n");
            Console.ReadLine();
            // User Selects Heads or Tails
            Console.WriteLine(coinTossFlip);
            Console.ReadKey();
            // Console.Write($"Congratulations + {winner}, you get the ball first!");
            // InGamePlay();
        }

        public void InGamePlay()
        {
            Console.Clear();
            //Console.WriteLine($"Since {P1} won the coin toss they will go first!");

            //PlayerOneTurn
            //Pass/Run
            //Execute 4 plays = Possession
            //PlayerTwoTurn
            //Pass/Run
            //ShowScore

            //PlayerOneTurn
            //PlayerTwoTurn
            //ShowScore

            //PlayerOneTurn
            //PlayerTwoTurn
            //ShowScore

            //PlayerOneTurn
            //PlayerTwoTurn
            //ShowScore

            //Compare Score, bigger score wins

            // Team gets 4 plays to try and get as many yards as possible ( 1 play equals a quarter, after every quarter, show the score)
            // Before every turn, the user picks whether or not to PASS or RUN
            // If PASS include QB passing to RB, WR, or TE
            // Randomly Select Player to pass to, (the better the player, the higher chance for more yards)
            // Maybe include a small % for QB run here
            // If RUN include RB1 80% RB2 20%
            // If team gets 75 or more than touchdown 6points, then choice to go for 1 or 2
            // 95% for 1 point 50% for 2 points
            // Screen congratulating on scoring or screen showing missed field goal
            // Next team goes
            // Both teams get 3 possessions (when testing, more for when we are done)
            // Could include a small % based on Defense Stats to include a turnover during opponents possession
            // For example 5% chance of a sack = loss of play or even loss of yards on play
            // Interception or Fumble equals possession ending
        }

        //private void PlayerOneTurn(string user, string aI)
        //{
        //    ScoreTable(playerScore);                            

        //    if (possessions != maxPossessions)                                        
        //    {                                  
        //        if (plays != maxPlays)
        //        {
        //            // if run
        //                // add yards
        //            // else if pass complete
        //                // add yards
        //            // else if pass incomplete
        //                // add 0 yards
        //            // else possession ends (turnover)
        //        }
        //    }
        //}

        public string PlayerOneSelection()
        {
            Console.Clear();

            string choice;
            Console.WriteLine("Choose what kind of play do you want!\n" + "1. Pass\n" + "2. Run\n");

            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    choice = "Pass";
                    return choice;
                case "2":
                    choice = "Run";
                    return choice;
                default:
                    PlayerOneSelection();
                    break;
            }
            return null;
        }

        public void ColtsPassing()
        {
            Dictionary<string, dynamic> qbDictionary = GetPlayerDictionaryByPosition(Position.QB);
            Dictionary<string, dynamic> rb1Dictionary = GetPlayerDictionaryByPosition(Position.RB1);
            Dictionary<string, dynamic> rb2Dictionary = GetPlayerDictionaryByPosition(Position.RB2);
            Dictionary<string, dynamic> wr1Dictionary = GetPlayerDictionaryByPosition(Position.WR1);
            Dictionary<string, dynamic> wr2Dictionary = GetPlayerDictionaryByPosition(Position.WR2);
            Dictionary<string, dynamic> teDictionary = GetPlayerDictionaryByPosition(Position.TE);

            // QB Completes 80% insert passing randomizer
            if (PassingCompletionRandomizer() <= 80)
            {
                Console.WriteLine($"QB {qbDictionary[nameKey]} completes a...");
                // who does he pass to?  WR1 35%, WR2 30%, TE 20% RB1 10%, RB2 5%

                if (GetWhoIsCatchingThePass() <= 5)
                {
                    Console.Write($"_____ yard pass to RB {rb2Dictionary[nameKey]}");
                    // RB2 Catches the ball for 1-4
                }
                else if (GetWhoIsCatchingThePass() <= 15)
                {
                    Console.Write($"______ yard pass to RB {rb1Dictionary[nameKey]}");
                    // RB1 Catches the ball for 1-7
                }
                else if (GetWhoIsCatchingThePass() <= 35)
                {
                    Console.Write($"______ yard pass to TE {teDictionary[nameKey]}");
                    // TE Catches the ball for 5-12
                }
                else if (GetWhoIsCatchingThePass() <= 65)
                {
                    Console.Write($"{WR2YardRandomizer()} yard pass to WR {wr2Dictionary[nameKey]}");
                    // WR2 Catches the ball for 7-14
                }
                else
                {
                    Console.Write($"{WR1YardRandomizer()} yard pass to WR {wr1Dictionary[nameKey]}");
                    // WR1 Catches the ball for 9-20
                }
            }
            else
            {
                Console.WriteLine($"QB {qbDictionary[nameKey]} throws an incomplete pass");
                // Pass is incomplete add 0 yards
            }
        }

        public int ColtsRunning()
        {
            // Who runs? 80% RB1, 20% RB2
            if (RunningRandomizer() <= 20)
            {
                int rb2Yards = RB2YardRandomizer();
                return rb2Yards;
            }
            else
            {
                int rb1Yards = RB1YardRandomizer();
                return rb1Yards;
            }
        }

        private int RunningRandomizer()
        {
            Random yards = new Random();
            int runningBack = yards.Next(1, 101);
            return runningBack;
        }

        private int RB1YardRandomizer()
        {
            Random yards = new Random();
            int runYards = yards.Next(0, 9);
            return runYards;
        }

        private int RB2YardRandomizer()
        {
            Random yards = new Random();
            int runYards = yards.Next(1, 16);
            return runYards;
        }

        private int WR1YardRandomizer()
        {
            Random yards = new Random();
            int receivingYards = yards.Next(9, 21);
            return receivingYards;
        }

        private int WR2YardRandomizer()
        {
            Random yards = new Random();
            int receivingYards = yards.Next(7, 15);
            return receivingYards;
        }


        private int PassingCompletionRandomizer()
        {
            Random yards = new Random();
            int completion = yards.Next(1, 101);
            return completion;
        }

        private int GetWhoIsCatchingThePass()
        {
            Random yards = new Random();
            int receiver = yards.Next(1, 101);
            return receiver;
        }



        private Dictionary<string, dynamic> GetPlayerDictionaryByPosition(Position position)
        {
            foreach (Dictionary<string, dynamic> playerDictionary in coltsPlayerArray)
            {
                if (playerDictionary[positionKey] == position)
                {
                    return playerDictionary;
                }
            }
            return null;
        }

        private string CoinTossResult(Dictionary<string, int> coinToss)
        {
            Console.Clear();
            Random rand = new Random();
            int num = rand.Next(1, 3);
            foreach (var data in coinToss)
            {
                if (data.Value == num)
                {
                    return data.Key;
                }
            }
            return null;
        }

        private int FieldGoalRandomizer()
        {
            Random yards = new Random();
            int fieldGoal = yards.Next(1, 101);
            return fieldGoal;
        }

        private string FieldGoalPercentage() // Still need to add a +0 or +3 to score in this method
        {
            int yards = 0;
            if (yards < 30)
            {
                //Console.WriteLine($"{Team} has turned the ball over.")
            }
            else if (yards <= 34)
            {
                if (FieldGoalRandomizer() <= 30)
                {
                    //Console.WriteLine($"{Team} has made a yard fieldgoal!")
                }
                else
                {
                    //Console.WriteLine($"{Team} has missed a yard fieldgoal!")
                }
            }
            else if (yards <= 39)
            {
                if (FieldGoalRandomizer() <= 50)
                {
                    //Console.WriteLine($"{Team} has made a yard fieldgoal!")
                }
                else
                {
                    //Console.WriteLine($"{Team} has missed a yard fieldgoal!")
                }
            }
            else if (yards <= 44)
            {
                if (FieldGoalRandomizer() <= 60)
                {
                    //Console.WriteLine($"{Team} has made a yard fieldgoal!")
                }
                else
                {
                    //Console.WriteLine($"{Team} has missed a yard fieldgoal!")
                }
            }
            else if (yards <= 54)
            {
                if (FieldGoalRandomizer() <= 75)
                {
                    //Console.WriteLine($"{Team} has made a yard fieldgoal!")
                }
                else
                {
                    //Console.WriteLine($"{Team} has missed a yard fieldgoal!")
                }
            }
            else if (yards <= 64)
            {
                if (FieldGoalRandomizer() <= 85)
                {
                    //Console.WriteLine($"{Team} has made a yard fieldgoal!")
                }
                else
                {
                    //Console.WriteLine($"{Team} has missed a yard fieldgoal!")
                }
            }
            else if (yards <= 74)
            {
                if (FieldGoalRandomizer() <= 95)
                {
                    //Console.WriteLine($"{Team} has made a yard fieldgoal!")
                }
                else
                {
                    //Console.WriteLine($"{Team} has missed a yard fieldgoal!")
                }
            }
            return null;

            // If team gets 65-74 yards, then gets the opportunity for 95% 3 point field goal
            // If team gets 55-64 yards, then gets the opportunity for 85% 3 point field goal
            // If team gets 45-54 yards, then gets the opportunity for 75% 3 point field goal
            // If team gets 40-44 yards, then gets the opportunity for 60% 3 point field goal
            // If team gets 35-39 yards, then gets the opportunity for 50% 3 point field goal
            // If team gets 30-34 yards, then gets the opportunity for 30% 3 point field goal
        }

        private Team ComputerTeamSelection()
        {
            Console.Clear();
            Random rand = new Random();
            Team num = (Team)rand.Next(1, 3);
            return num;
        }

        private string DisplaySelectedTeam(Team selectedTeam)
        {
            Console.Clear();
            Console.WriteLine($"You have picked the {selectedTeam}!");
            Console.WriteLine("Here is the starting lineup for the Colts!\n");
            foreach (Dictionary<string, dynamic> player in selectedTeam == Team.Colts ? coltsPlayerArray : jaguarsPlayerArray) // If Team.Colts use colts or jaguars
            {
                Console.WriteLine($"Name:{player[nameKey]}, Position:{player[positionKey]}, Rating:{player[ratingKey]}");
            }
            return null;
        }

        //private string Colts()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Colts!");
        //    Console.WriteLine("Here is the starting lineup for the Colts!");
        //    Console.WriteLine("");
        //    foreach (Dictionary<string, dynamic> player in coltsPlayerArray)
        //    {
        //        Console.WriteLine($"Name:{player[nameKey]}, Position:{player[positionKey]}, Rating:{player[ratingKey]}");
        //        Console.WriteLine("");
        //    }
        //    return null;
        //    // Console.WriteLine(${ListOfColtsPlayers} + {Stats})
        //}
        //private void Jaguars()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Jaguars!");
        //    Console.WriteLine("Here is the starting lineup for the Jaguars!");
        //    Console.WriteLine("");
        //    foreach (Dictionary<string, dynamic> player in jaguarsPlayerArray)
        //    {
        //        Console.WriteLine($"Name:{player[nameKey]}, Position:{player[positionKey]}, Rating:{player[ratingKey]}");
        //        Console.WriteLine("");
        //    }
        //    // Console.WriteLine(${ListOfJaguarsPlayers})
        //}
        //private void Texans()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Texans!");
        //    Console.WriteLine("Here is the starting lineup for the Texans!");
        //    // Console.WriteLine(${ListOfTexansPlayers})
        //}
        //private void Titans()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Titans!");
        //    Console.WriteLine("Here is the starting lineup for the Titans!");
        //    // Console.WriteLine(${ListOfTitansPlayers})
        //}
        //private void Buccaneers()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Buccaneers!");
        //    Console.WriteLine("Here is the starting lineup for the Buccaneers!");
        //    // Console.WriteLine(${ListOfBuccaneersPlayers})
        //}
        //private void Falcons()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Falcons!");
        //    Console.WriteLine("Here is the starting lineup for the Falcons!");
        //    // Console.WriteLine(${ListOfFalconsPlayers})
        //}
        //private void Panthers()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Panthers!");
        //    Console.WriteLine("Here is the starting lineup for the Panthers!");
        //    // Console.WriteLine(${ListOfPanthersPlayers})
        //}
        //private void Saints()
        //{
        //    Console.Clear();
        //    Console.WriteLine("You have picked the Saints!");
        //    Console.WriteLine("Here is the starting lineup for the Saints!");
        //    // Console.WriteLine(${ListOfSaintsPlayers})
        //}

        Random random = new Random();
        public int NormalPower()
        {
            Thread.Sleep(5);                                                    // Adds a pause in the program...5 seconds?
            int[] yards = { 0, 5, 10, 15 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public int IntermediatePower()
        {
            Thread.Sleep(5);
            int[] yards = { 0, 5, 10, 15, 20 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public int AdvancedPower()
        {
            Thread.Sleep(5);
            int[] yards = { 0, 5, 10, 15, 20, 25 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        //use counter to add "yards covered". When reaches 75 total, touchdown!
        private string GetUsersChoiceForTeam()
        {
            Console.WriteLine(
                "\n1. Colts\n" +
                "2. Jaguars\n" +
                "3. Texans\n" +
                "4. Titans\n" +
                "5. Buccaneers\n" +
                "6. Falcons\n" +
                "7. Panthers\n" +
                "8. Saints\n\n" +
                "9. Return to the Main Menu");
            string teamSelection = Console.ReadLine();
            switch (teamSelection)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                    return teamSelection;
                default:
                    return "9";
            }
        }
    }
}