using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Data
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }

        [ForeignKey("HomeTeam")]
        public int HomeTeamID { get; set; }
        public virtual Team HomeTeam { get; set; }

        [ForeignKey("AwayTeam")]
        public int AwayTeamID { get; set; }
        public virtual Team AwayTeam { get; set; }

        [Required]
        public DateTime GameDate { get; set; }
        [Required]
        public int HomeTeamScore { get; set; }
        [Required]
        public int AwayTeamScore { get; set; }
    }
}
