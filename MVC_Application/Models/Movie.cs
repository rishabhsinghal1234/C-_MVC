using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stocks { get; set; }

    }
}