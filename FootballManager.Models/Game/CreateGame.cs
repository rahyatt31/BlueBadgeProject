using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class CreateGame
    {
        public int GameID { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }
        [Required]
        public int HomeTeamScore { get; set; }
        [Required]
        public int AwayTeamScore { get; set; }
    }
}
