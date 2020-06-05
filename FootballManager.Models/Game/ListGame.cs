using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Game
{
    public class ListGame
    {
        public int GameID { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public DateTime GameDate { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
}
