using FootballManager.Models.Player;
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

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}