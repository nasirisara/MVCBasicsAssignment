using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasicsAssignment.Models;
using Microsoft.AspNetCore.Http;

namespace MVCBasicsAssignment.Controllers
{
    public class GuessingGame : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                int getRnd = Game.GetRandom(100);
                HttpContext.Session.SetInt32("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
            }
            else
            {
                ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Reset()
        {
            int getRnd = Game.GetRandom(100);
            HttpContext.Session.SetInt32("intRnd", getRnd);
            ViewBag.Rnd = getRnd;
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Index(int guessNumber)
        {


            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")) || guessNumber <= 0 || guessNumber >= 100))
            {
                int storedRnd = (int)HttpContext.Session.GetInt32("intRnd");
                string respons = Game.CheckGame(Convert.ToInt32(guessNumber), storedRnd);
                ViewBag.Result2 = respons;
            }
            else
            {
                ViewBag.Result2 = "Enter a number between 1 and 100 and Submit";
            }
            return View();
        }
    }
    }
