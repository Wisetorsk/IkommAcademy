using System;
using System.Collections.Generic;
using System.Text;
using FilmDemoWebApplication.Domain.Entities;

namespace FilmDemoWebApplication.Domain.Repositories
{
    public interface IFilmsRepository
    {
        IEnumerable<Film> Films { get; }
        void Add(Film film);
        void Update(Film film);
        void Delete(int filmId);
        Film GetById(int filmId);

        IEnumerable<Film> GetAllFilms();
    }
}
