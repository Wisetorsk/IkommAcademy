using System;
using System.Collections.Generic;
using FilmDemoWebApplication.Domain.Entities;
using System.Text;

namespace FilmDemoWebApplication.Domain.Repositories
{
    public class DummyFilmsRepository : IFilmsRepository
    {
        private List<Film> dummyFilms = new List<Film>
        {
            new Film {FilmID=1, Title="Airplace", Blurb="classic", Genre="Comedy", RentalPrice=5.49M},
            new Film {FilmID=2, Title="Ghostbusters", Blurb="classic", Genre="Comedy", RentalPrice=5.49M},
            new Film {FilmID=3, Title="Die Hard", Blurb="classic", Genre="Action", RentalPrice=5.49M}
        };

        public IEnumerable<Film> Films 
        { 
            get {
                return dummyFilms;
            } 
        }

        public void Add(Film film)
        {
            dummyFilms.Add(film);
        }

        public void Delete(int filmId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public Film GetById(int filmId)
        {
            throw new NotImplementedException();
        }

        public void Update(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
