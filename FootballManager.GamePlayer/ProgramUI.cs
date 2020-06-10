using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.GamePlayer
{
    public class ProgramUI
    {
        bool isGameActive = true;
        int playerOneStartingScore = 0;
        int playerTwoStartingScore = 0;
        int playerOneFinalPossession = 0;
        int playerTwoFinalPossession = 0;

        int startingPlay = 0;
        int lastPlay = 4;

        Dictionary<string, int> teamsToPower = new Dictionary<string, int>
        {
            { "Colts" , 88 },                                                      // Name of team, and the average off/def "Power"
            { "Jaguars" , 86 },
            { "Texans" , 84 },
            { "Titans" , 82 },
            { "Buccaneers" , 80 },
            { "Falcons" , 78 },
            { "Panthers" , 76 },
            { "Saints" , 74 }
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
            Console.WriteLine("Please select your Team!");

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

            string goodBye = "Goodbye!";
            string teamSelection = Console.ReadLine();                      
                                                                  
            switch (teamSelection)
            {
                case "1":
                    // Colts
                    break;
                case "2":
                    // Jaguars
                    break;
                case "3":                         
                    // Texans                     
                    break;
                case "4":
                    // Titans
                    break;
                case "5":
                    // Buccaneers
                    break;
                case "6":
                    // Falcons                   
                    break;
                case "7":
                    // Panthers
                    break;
                case "8":
                    // Saints
                    break;
                default:                                      
                    RunMenu();                                   
                    break;                                            
            }

            // Picking your team
            // Picking your opponents team or random opponent team
            // Having a reselect team option
            // Are you ready to start game option
            // CoinToss();
        }

        public void ViewTeams()
        {
            // List of all teams with their power shown
            // Selecting team will pull up the players and their power
            // Console.ReadKey();
            // ViewTeams();
            // RunMenu();
        }

        public void CoinToss()
        {
            // Just a 50/50 Coin Toss to determine who gets the ball first
            // Console.Write($"Congratulations + {winner}, you get the ball first!");
            // InGamePlay();
        }

        public void InGamePlay()
        {
            // Team gets 4 plays to try and get as many yards as possible ( 1 play equals a quarter, after every quarter, show the score)
            // Before every turn, the user picks whether or not to PASS or RUN
                // If PASS include QB passing to RB, WR, or TE
                    // Randomly Select Player to pass to, (the better the player, the higher chance for more yards)
                    // Maybe include a small % for QB run here
                // If RUN include RB1 80% RB2 20%
                  
            // If team gets 75 or more than touchdown 6points, then choice to go for 1 or 2
            // 95% for 1 point 50% for 2 points
            // If team gets 65-74 yards, then gets the opportunity for 95% 3 point field goal
            // If team gets 55-64 yards, then gets the opportunity for 85% 3 point field goal
            // If team gets 45-54 yards, then gets the opportunity for 75% 3 point field goal
            // If team gets 40-44 yards, then gets the opportunity for 60% 3 point field goal
            // If team gets 35-39 yards, then gets the opportunity for 50% 3 point field goal
            // If team gets 30-34 yards, then gets the opportunity for 30% 3 point field goal
            // Screen congratulating on scoring or screen showing missed field goal
            // Next team goes
            // Both teams get 3 possessions (when testing, more for when we are done)

            // Could include a small % based on Defense Stats to include a turnover during opponents possession
                // For example 5% chance of a sack = loss of play or even loss of yards on play
                // Interception or Fumble equals possession ending
        }












        Random random = new Random();

        public int NormalPower()
        {
            Thread.Sleep(5);                                                    // Adds a pause in the program...5 seconds?
            int[] yards = {0, 5, 10, 15 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public int IntermediatePower()
        {
            Thread.Sleep(5);
            int[] yards = {0, 5, 10, 15, 20 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        public int AdvancedPower()
        {
            Thread.Sleep(5);
            int[] yards = {0, 5, 10, 15, 20, 25 };
            int yardsCovered = random.Next(yards.Length);
            return yardsCovered;
        }

        //use counter to add "yards covered". When reaches 75 total, touchdown!

    }
}
