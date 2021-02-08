using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySite.Models;
using MySite.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        private Dimentions dimentions = new Dimentions();
        private Hobby hobbies = new Hobby();

        [HttpGet]
        public IActionResult Index()
        {
            return View(dimentions);
        }

        [HttpPost]
        public IActionResult Index(Dimentions dimentions)
        {
            return View("GameOfLife", dimentions);
        }

        public IActionResult AboutMe()
        {
            return View(hobbies);
        }
        public IActionResult GameOfLife() {
            return View();
        }

    }
}
