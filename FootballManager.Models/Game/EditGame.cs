using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class EditGame
    {
        public int GameInfoID { get; set; }         // Able to change the gameID
        public int HomeTeamID { get; set; }         // Able to change the Home Team
        public int AwayTeamID { get; set; }         // Able to change the Away Team
        public DateTime GameDate { get; set; }      // Able to change the Date of the Game
        public int HomeTeamScore { get; set; }      // Able to change the Home Team's Score
        public int AwayTeamScore { get; set; }      // Able to change the Away Team's Score
    }
}