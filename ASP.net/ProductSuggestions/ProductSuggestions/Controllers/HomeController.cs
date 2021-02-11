using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductSuggestions.Models;

namespace ProductSuggestions.Controllers
{
    public class HomeController : Controller
    {
        // Allow the user to query product suggestions (i.e. GET product suggestions).
        public ActionResult Index()
        {
            return View();
        }

        // Allow the user to manage product suggestions (i.e. INSERT, UPDATE, DELETE product suggestions).
        public ActionResult Manage()
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
