using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationGames.Models;

namespace WebApplicationGames.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View("index");
        }
        public IActionResult RockPaperScissors()
        {
            RockPaperScissorsModel model = new RockPaperScissorsModel();
            return View(model);
        }

        public IActionResult RockPaperScissorsPlay(RockPaperScissorsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("RockPaperScissors", model);
            }

            Random rnd = new Random();
            string[] options = { "Rock", "Paper", "Scissors" };
            model.Computer = options[rnd.Next(0, 3)];
            model.Player = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(model.Player.ToLower());

                switch (model.Computer)
                {
                    case "Rock":
                        if (model.Player == "Rock")
                        {
                            model.Winner = "Tie";
                        }
                        if (model.Player == "Paper")
                        {
                            model.Winner = "Player";
                        }
                        if (model.Player == "Scissors")
                        {
                            model.Winner = "Computer";
                        }
                        break;

                    case "Paper":
                        if (model.Player == "Paper")
                        {
                            model.Winner = "Tie";
                        }
                        if (model.Player == "Rock")
                        {
                            model.Winner = "Computer";
                        }
                        if (model.Player == "Scissors")
                        {
                            model.Winner = "Player";
                        }
                        break;

                    case "Scissors":
                        if (model.Player == "Scissors")
                        {
                            model.Winner = "Tie";
                        }
                        if (model.Player == "Rock")
                        {
                            model.Winner = "Player";
                        }
                        if (model.Player == "Paper")
                        {
                            model.Winner = "Computer";
                        }
                        break;
                }
                return View("RockPaperScissors", model);

            
        }

        public IActionResult GuessANumber()
        {
            GuessANumberModel model = new GuessANumberModel();
            return View(model);
        }

        public IActionResult GuessANumberPlay(GuessANumberModel model)
        {
            Random rnd = new Random();
            int[] options = { 1,2,3,4,5,6,7,8,9,10 };
            model.Computer = options[rnd.Next(0, 10)];

            if (model.Player == model.Computer)
            {
                model.Winner = "Player";
            }
            if (model.Player > model.Computer || model.Player < model.Computer)
            {
                model.Winner = "Computer";
            }

            return View("GuessANumber", model);
        }

        public IActionResult GuessAWord()
        {
            GuessAWordModel model = new GuessAWordModel();
            return View(model);
        }

        public IActionResult GuessAWordPlay(GuessAWordModel model)
        {
            Random rnd = new Random();
            string[] options = { "Watermellon", "Calendar", "Database", "Festival", "Triangle" };
            model.Computer = options[rnd.Next(0, 5)];
            model.Player = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(model.Player.ToLower());
            model.Hint = 


            return View("GuessAWord", model);
        }
    }



}
