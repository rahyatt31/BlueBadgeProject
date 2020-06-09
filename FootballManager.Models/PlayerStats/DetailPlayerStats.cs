using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.PlayerStats
{
    public class DetailPlayerStats
    {
        public int PlayerStatsID { get; set; }
        public int PlayerID { get; set; }
        public int PassingYards { get; set; }
        public int PassingTouchdowns { get; set; }
        public int InterceptionThrown { get; set; }
        public int RushingYards { get; set; }
        public int RushingAttempts { get; set; }
        public int RushingTouchDowns { get; set; }
        public int ReceivingYards { get; set; }
        public int Catches { get; set; }
        public int ReceivingTouchDowns { get; set; }
        public int Fumbles { get; set; }
        public int Tackles { get; set; }
        public double Sacks { get; set; }
        public int Interceptions { get; set; }
        public int ForcedFumbles { get; set; }
        public int FumbleRecovery { get; set; }
        public int Safety { get; set; }
        public int BlockedKick { get; set; }
        public int ReturnTouchDown { get; set; }
    }
}
