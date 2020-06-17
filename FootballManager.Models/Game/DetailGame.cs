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
    public class DetailGame
    {
        [DisplayName("Game ID")]
        public int GameID { get; set; }
        [Required, DisplayName("Game Date")]
        public DateTime GameDate { get; set; }
        [Required, DisplayName("Home Team Score")]
        public int HomeTeamScore { get; set; }
        [Required, DisplayName("Away Team Score")]
        public int AwayTeamScore { get; set; }
    }
}
