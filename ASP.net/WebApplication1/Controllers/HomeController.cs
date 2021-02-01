using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void TestAction()
        {
            Console.WriteLine("TESTING!!!");
            //return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult HiNorsk()
        {
            AddData();
            ViewData["timeOffset"] = 1;
            ViewData["country"] = "Norway";
            return View();
        }
        public IActionResult HiWelsh()
        {
            ViewData["timeOffset"] = 0;
            ViewData["country"] = "Wales";
            return View();
        }

        public void AddData()
        {
            ViewData["people"] = new List<string>() { "Person1", "Person2", "Person3", "Person4", "Person5" };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
