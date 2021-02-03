using FilmDemoWebApplication.Domain;
using FilmDemoWebApplication.Domain.Entities;
using FilmDemoWebApplication.Domain.Repositories;
using FilmDemoWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDemoWebApplication.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmsRepository filmsRepository;

        public FilmsController()
        {
            filmsRepository = new DummyFilmsRepository();
        }

        public IActionResult List()
        {
            var films = filmsRepository.Films;
            return View(films);
        }

       
    }
}
