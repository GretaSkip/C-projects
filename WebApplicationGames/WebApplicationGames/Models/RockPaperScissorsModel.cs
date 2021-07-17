using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGames.Models
{
    public class RockPaperScissorsModel
    {
        [Required(ErrorMessage = "Please Enter Your Choice!")]
        public string Player { get; set; }
        public string Computer { get; set; }
        public string Winner { get; set; }

    }
}
