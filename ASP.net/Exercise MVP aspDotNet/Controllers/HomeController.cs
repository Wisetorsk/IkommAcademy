using Exercise_MVP_aspDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_MVP_aspDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            ViewData["Name"] = "EnterName";
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NameEntry()
        {
            ViewData["Title"] = "Name Entry";
            ProductSuggestion data = new ProductSuggestion();
            return View(data);
        }

        [HttpPost]
        public IActionResult NameEntry(ProductSuggestion data)
        {
            ViewData["Title"] = "Name Entry 2";
            ViewData["Name"] = data.UserName;
            return RedirectToAction("ConfirmEntry", "Home", new { userName = data.UserName });
        }

        [HttpGet]
        public IActionResult ConfirmEntry(string userName)
        {
            ViewData["Title"] = "Confirm Entry";
            ViewData["Name"] = userName;
            ProductSuggestion data = new ProductSuggestion();
            data.UserName = userName;
            //data.Description = "this is a test descripiton";
            return View(data);
        }

        [HttpPost]
        public IActionResult ConfirmEntry(ProductSuggestion data)
        {
            ViewData["Title"] = "Product Overview";
            ViewData["Name"] = data.UserName;
            if (ModelState.IsValid)
            {
                return View("ProductOverview", data);
            }
            else
            {
                return View(data);
            }
        }
    }
}
