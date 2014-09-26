using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Bring in the objects
using MvcPractice.Models;

namespace MvcPractice.Controllers
{
    public class HighScoresController : Controller
    {
        //
        // GET: /HighScores/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BattleShip()
        {
            HighScoresEntities db = new HighScoresEntities();
            return View(db.HighScores.Where(x => x.Game == "Battleship").OrderBy(x => x.Score));
        }

        public ActionResult DragonSlayer()
        {
            HighScoresEntities db = new HighScoresEntities();
            return View(db.HighScores.Where(x => x.Game == "Dragon Slayer").OrderBy(x => x.Score));
        }

        public ActionResult DragonSlayerV2()
        {
            HighScoresEntities db = new HighScoresEntities();
            return View(db.HighScores.Where(x => x.Game == "Dragon Slayer V2").OrderBy(x => x.Score));
        }

        public ActionResult GuessThatNumber()
        {
            HighScoresEntities db = new HighScoresEntities();
            return View(db.HighScores.Where(x => x.Game == "Guess That Number").OrderBy(x => x.Score));
        }

        public ActionResult Hangman()
        {
            HighScoresEntities db = new HighScoresEntities();
            return View(db.HighScores.Where(x => x.Game == "Hangman").OrderBy(x => x.Score));
        }

        public ActionResult Trivia()
        {
            HighScoresEntities db = new HighScoresEntities();
            return View(db.HighScores.Where(x => x.Game == "Trivia").OrderBy(x => x.Score));
        }
    }
}
