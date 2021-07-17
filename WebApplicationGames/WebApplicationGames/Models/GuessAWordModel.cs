using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGames.Models
{
    public class GuessAWordModel
    {
        public string Player { get; set; }
        public string Computer { get; set; }
        public string Hint { get; set; }
        public string Winner { get; set; }

    }
}
