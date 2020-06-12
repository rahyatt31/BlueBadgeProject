using FootballManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace FootballManager.GamePlayer
{
    public class ProgramUI
    {
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
        int playerOneFinalPossession = 0;
        int playerTwoFinalPossession = 0;
        int startingPlay = 0;
        int lastPlay = 4;
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
            TeamListMethod();
            // Picking your team    DONE
            // Picking your opponents team or
            Console.ReadLine();
            //Console.WriteLine($"Todays Game will be played between {PlayerOneSelection} and {PlayerTwoSelection}");
            OpponentChoice();
            // Having a reselect team option
            // Are you ready to start game option
            CoinToss();
        }
        private void OpponentChoice()
        {
            Console.Clear();
            Console.WriteLine("Would you like to select your opponent or have it be selected for you?");
            Console.WriteLine("\n1. Select your opponent!\n" + "2. Select to have a random opponent!\n");
            string doYouWantToPickYourOpponent = Console.ReadLine();
            switch (doYouWantToPickYourOpponent)
            {
                case "1":
                    OpponentChoiceOne();
                    break;
                case "2":
                    OpponenetChoiceTwo();
                    break;
                case "3":
                default:
                    break;
            }
        }
        private void OpponentChoiceOne()
        {
            Console.Clear();
            Console.WriteLine("Player Two, please select your Team!");
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
            TeamListMethod();
        }
        private void OpponenetChoiceTwo()
        {
            Console.Clear();
            string randomTeamSelection = ComputerTeamSelection(computerTeamSelection);
            Console.WriteLine($"Your opponent will be {randomTeamSelection}!");
            Console.ReadKey();
        }
        public void ViewTeams()
        {
            // List of all teams with their power shown
            // Selecting team will pull up the players and their power
            // Console.ReadKey();
            // ViewTeams();
            // Console.Readkey();
            // RunMenu();
            // At least 2 methods similar to swapi, to bring in Teams and Team Details from API
        }
        public void CoinToss()
        {
            string coinTossFlip = CoinTossResult(coinToss);
            // Just a 50/50 Coin Toss to determine who gets the ball first
            Console.Clear();
            Console.WriteLine("It's time to do the coin toss, would you like Heads or Tails?");
            Console.WriteLine("\n1. Heads!\n" + "2. Tails\n");
            Console.ReadLine();
            // User Selects Heads or Tails
            Console.ReadKey();
            Console.WriteLine(coinTossFlip);
            Console.ReadKey();
            // Console.Write($"Congratulations + {winner}, you get the ball first!");
            // InGamePlay();
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
        private string ComputerTeamSelection(Dictionary<string, int> computerSelection)
        {
            Console.Clear();
            Random rand = new Random();
            int num = rand.Next(1, 9);
            foreach (var data in computerSelection)
            {
                if (data.Value == num)
                {
                    return data.Key;
                }
            }
            return null;
        }
        private void Colts()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Colts!");
            Console.WriteLine("Here is the starting Lineup for the Colts!");
            // Console.WriteLine(${ListOfColtsPlayers} + {Stats})
        }
        private void Jaguars()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Jaguars!");
            Console.WriteLine("Here is the starting Lineup for the Jaguars!");
            // Console.WriteLine(${ListOfJaguarsPlayers})
        }
        private void Texans()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Texans!");
            Console.WriteLine("Here is the starting Lineup for the Texans!");
            // Console.WriteLine(${ListOfTexansPlayers})
        }
        private void Titans()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Titans!");
            Console.WriteLine("Here is the starting Lineup for the Titans!");
            // Console.WriteLine(${ListOfTitansPlayers})
        }
        private void Buccaneers()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Buccaneers!");
            Console.WriteLine("Here is the starting Lineup for the Buccaneers!");
            // Console.WriteLine(${ListOfBuccaneersPlayers})
        }
        private void Falcons()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Falcons!");
            Console.WriteLine("Here is the starting Lineup for the Falcons!");
            // Console.WriteLine(${ListOfFalconsPlayers})
        }
        private void Panthers()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Panthers!");
            Console.WriteLine("Here is the starting Lineup for the Panthers!");
            // Console.WriteLine(${ListOfPanthersPlayers})
        }
        private void Saints()
        {
            Console.Clear();
            Console.WriteLine("You have picked the Saints!");
            Console.WriteLine("Here is the starting Lineup for the Saints!");
            // Console.WriteLine(${ListOfSaintsPlayers})
        }
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
        private void TeamListMethod()
        {
            string teamSelection = Console.ReadLine();
            switch (teamSelection)
            {
                case "1":
                    Colts();
                    break;
                case "2":
                    Jaguars();
                    break;
                case "3":
                    Texans();
                    break;
                case "4":
                    Titans();
                    break;
                case "5":
                    Buccaneers();
                    break;
                case "6":
                    Falcons();
                    break;
                case "7":
                    Panthers();
                    break;
                case "8":
                    Saints();
                    break;
                default:
                    RunMenu();
                    break;
            }
        }
    }
}