﻿using FootballManager.Models.Player;
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
        public List<ListPlayer> TeamPlayers { get; set; } //Get ICollection into List<ListPlayer>

        //public int TeamOffenseYardsPerGame { get; set; }
        //public double TeamOffensePointsPerGame { get; set; }
        //public double TeamOffensiveTouchdownsPerGame { get; set; }
        //public double TeamOffenseTurnoversPerGame { get; set; }
        //public int TeamDefenseYardsPerGame { get; set; }
        //public double TeamDefensePointsPerGame { get; set; }
        //public double TeamDefenseTurnoversPerGame { get; set; }
        //public double TeamDefensiveTouchdownsPerGame { get; set; }
    }
}
