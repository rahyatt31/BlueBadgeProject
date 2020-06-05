using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Player
{
    public class DetailPlayer
    {
        public int PlayerID { get; set; }
        public Guid TeamID { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public string PlayerPosition { get; set; }
        public int PlayerJerseyNumber { get; set; }
        public double PlayerHeightByInches { get; set; }
        public double PlayerWeightByPounds { get; set; }
    }
}
