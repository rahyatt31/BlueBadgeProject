using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class ListGame
    {
        [DisplayName("Game ID")]
        public int GameID { get; set; }
        [DisplayName("Home Team ID")]
        public int HomeTeamID { get; set; }
        [DisplayName("Away Team ID")]
        public int AwayTeamID { get; set; }
        [DisplayName("Game Date")]
        public DateTime GameDate { get; set; }
        [DisplayName("Home Team Score")]
        public int HomeTeamScore { get; set; }
        [DisplayName("Away Team Score")]
        public int AwayTeamScore { get; set; }
    }
}
