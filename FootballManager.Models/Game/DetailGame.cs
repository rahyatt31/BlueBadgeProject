using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class DetailGame
    {
        public int GameID { get; set; }

        [Required]
        public DateTime GameDate { get; set; }
        [Required]
        public int HomeTeamScore { get; set; }
        [Required]
        public int AwayTeamScore { get; set; }
    }
}
