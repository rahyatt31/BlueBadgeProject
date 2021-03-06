﻿using FootballManager.Models.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Team
{
    public class DetailTeam
    {
        [DisplayName("Team ID")]
        public int TeamID { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        [DisplayName("Players")]
        public List<ListPlayer> TeamPlayers { get; set; } //Get ICollection from Team into List<ListPlayer>
    }
}
