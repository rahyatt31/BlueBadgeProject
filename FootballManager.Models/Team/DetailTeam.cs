using FootballManager.Models.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Team
{
    public class DetailTeam
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<ListPlayer> TeamPlayers { get; set; } //Get ICollection from Team into List<ListPlayer>
    }
}
