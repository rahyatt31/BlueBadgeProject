﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Player
{
    public class EditPlayer
    {
        [DisplayName("Player ID")]
        public int PlayerID { get; set; }
        [DisplayName("Team ID")]
        public int TeamID { get; set; }
        [DisplayName("First Name")]
        public string PlayerFirstName { get; set; }
        [DisplayName("Last Name")]
        public string PlayerLastName { get; set; }
        [DisplayName("Position")]
        public string PlayerPosition { get; set; }
        [DisplayName("Jersey Number")]
        public int PlayerJerseyNumber { get; set; }
        [DisplayName("Height")]
        public double PlayerHeightByInches { get; set; }
        [DisplayName("Weight")]
        public double PlayerWeightByPounds { get; set; }
    }
}
