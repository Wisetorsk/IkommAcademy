using System;

namespace FilmDemoWebApplication.Domain.Entities
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public string Genre { get; set; }
        public decimal RentalPrice { get; set; }

    }
}
