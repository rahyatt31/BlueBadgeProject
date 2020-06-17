using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class EditGame
    {
        [DisplayName("Game ID")]
        public int GameID { get; set; }         // Able to change the gameID
        [DisplayName("Home Team ID")]
        public int HomeTeamID { get; set; }         // Able to change the Home Team
        [DisplayName("Away Team ID")]
        public int AwayTeamID { get; set; }         // Able to change the Away Team
        [DisplayName("Game Date")]
        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }      // Able to change the Date of the Game
        [DisplayName("Home Team Score")]
        public int HomeTeamScore { get; set; }      // Able to change the Home Team's Score
        [DisplayName("Away Team Score")]
        public int AwayTeamScore { get; set; }      // Able to change the Away Team's Score
    }
}