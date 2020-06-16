using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Player
{
    [NotMapped]
    public class CreatePlayer
    {
        //public int PlayerID { get; set; } //not needed in model. Gets generated in the database
        [Required]
        public int TeamID { get; set; }

        [Required]
        public string PlayerFirstName { get; set; }
        [Required]
        public string PlayerLastName { get; set; }

        [MaxLength(2, ErrorMessage = "Please enter the abbriviation with consisting of only 2 characters. (QB, RB, WR, TE, OL, DL, LB, CB, FS, SS)")]
        //Stretch Goal -- Make Enum
        public string PlayerPosition { get; set; }

        [Required]
        [Range(0,99, ErrorMessage = "Jersey number can only be 2 digits and has to be between 0 and 99.")]
        public int PlayerJerseyNumber { get; set; }

        [Required]
        public double PlayerHeightByInches { get; set; }
        [Required]
        public double PlayerWeightByPounds { get; set; }
    }
}
