using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGames.Models
{
    public class GuessANumberModel
    {
        [Required(ErrorMessage = "Please Enter Your Guess!")]
        public int? Player { get; set; }
        public int Computer { get; set; }
        public string Winner { get; set; }
    }
}
