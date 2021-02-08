using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolidayGuru.Models;

namespace HolidayGuru.Controllers
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

        [HttpGet]
        public IActionResult AnotherPage()
        {
            AnotherPage page = new AnotherPage(); //Model for the anotherPage View
            return View(page); // Returns the view with the model bound to it
        }

        [HttpPost]
        public IActionResult AnotherPage(AnotherPage page)
        {
            if (ModelState.IsValid)
            {
                return View("ConfirmationPage", page);
            }
            return View(page); // Returns the view with the model bound to it
        }

        [HttpGet]
        public IActionResult AddReview()
        {
            HolidayReview review = new HolidayReview();
            return View(review);
        }

        [HttpPost]
        public IActionResult AddReview(HolidayReview review)
        {
            if (ModelState.IsValid)
            {
                review.Submit();
                return View("AcceptReview", review);
            }
            else
            {
                // Validation error, so re-display Review form.
                return View(review);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
