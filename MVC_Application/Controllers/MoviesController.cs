using MVC_Application.Models;
using MVC_Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Random(int id)
        {
            var movie = new Movie() { Name = "Avengers" , Id=id};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
                new Customer {Name = "Customer 3"},
                new Customer {Name = "Customer 4"},
                new Customer {Name = "Customer 5"}
            };

            var viewModel = new RandomMovieViewModel { Movie=movie, Customers=customers };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }

        public ActionResult Index()
        {
            //if (!pageNumber.HasValue)
            //    pageNumber = 1;
            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Date";
            //return Content(String.Format("PageNumber={0} & SortBy={1}", pageNumber, sortBy));
            var movies = _context.Movies.ToList();
            //var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        [Route("movies/release/{year}/{month:range(1, 12)}")]
        public ActionResult Release(int year, int month)
        {
            return Content(year+"/"+month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1, Name="Time Trap"},
                new Movie{Id=2, Name="Intersteller"}
            };
        }
    }

}