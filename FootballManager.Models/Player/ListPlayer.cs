using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Player
{
    public class ListPlayer
    {
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
    }
}
