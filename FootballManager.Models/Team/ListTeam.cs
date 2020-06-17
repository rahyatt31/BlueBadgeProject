using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Team
{
    public class ListTeam
    {
        [DisplayName("Team ID")]
        public int TeamID { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
    }
}
