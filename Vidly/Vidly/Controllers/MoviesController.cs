using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        
        [Route("random")]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer> {
                
                 new Customer { Name="Customer 1"},
                 new Customer { Name="Customer 2"}

            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    
       [Route("movies/released/{year:regex(\\d{4}):range(2010,2023)}/{month:regex(\\d{2}):range(1,12)}")]
       public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/"+ month);
        }

        [Route("movies/details/{id}/{name}")]
        public ActionResult Details(int id, string name) {

            var movie = new Movie { 
                Id = id,
                Name = name
            };
            return View(movie);
        }
    
        [Route("movies")]
        public ActionResult Movies()
        {
            var movieList = new List<Movie> {

            new Movie{Id=1,Name="Up" },
            new Movie{Id=2,Name="Shrek" },
            new Movie{Id =3,Name="Lord of the Rings" }

            };

            var viewModel = new MovieViewModel
            {
                Movies = movieList
            };
            return View(viewModel);
        }
    }
}

