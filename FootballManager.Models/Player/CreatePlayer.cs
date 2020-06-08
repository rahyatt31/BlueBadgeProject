using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.Player
{
    public class CreatePlayer
    {
        public int PlayerID { get; set; }
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
        //[MaxLength(2, ErrorMessage = "Please enter the abbriviation with consisting of only 2 characters. (01-99)")]
        public int PlayerJerseyNumber { get; set; }

        [Required]
        public double PlayerHeightByInches { get; set; }
        [Required]
        public double PlayerWeightByPounds { get; set; }
    }
}
