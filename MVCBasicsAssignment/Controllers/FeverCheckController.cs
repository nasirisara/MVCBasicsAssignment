using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasicsAssignment.Models;

namespace MVCBasicsAssignment.Controllers

    {
        public class FeverCheckController : Controller
        {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Index(double temp, string type)
            {

                ViewBag.Fever = CheckFever.Check(temp, type);

                return View();
            }
        }

    }

