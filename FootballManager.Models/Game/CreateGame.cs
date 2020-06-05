using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class CreateGame
    {
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }

        [Required]
        public DateTime GameDate { get; set; }
        [Required]
        public int HomeTeamScore { get; set; }
        [Required]
        public int AwayTeamScore { get; set; }
    }
}
