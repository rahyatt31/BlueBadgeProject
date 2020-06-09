using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Team
{
    public class CreateTeam
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }
}
