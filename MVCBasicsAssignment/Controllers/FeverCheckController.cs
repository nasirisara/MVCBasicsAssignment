﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment.Controllers
{
  
        public class FeverCheckController : Controller
        {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }
            
        }
}
