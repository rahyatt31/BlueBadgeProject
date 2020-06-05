using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public string TeamName { get; set; }

        //[Required]
        //public int TeamOffenseYardsPerGame { get; set; }
        //[Required]
        //public double TeamOffensePointsPerGame { get; set; }
        //[Required]
        //public double TeamOffensiveTouchdownsPerGame { get; set; }
        //[Required]
        //public double TeamOffenseTurnoversPerGame { get; set; }
        //[Required]
        //public int TeamDefenseYardsPerGame { get; set; }
        //[Required]
        //public double TeamDefensePointsPerGame { get; set; }
        //[Required]
        //public double TeamDefenseTurnoversPerGame { get; set; }
        //[Required]
        //public double TeamDefensiveTouchdownsPerGame { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}