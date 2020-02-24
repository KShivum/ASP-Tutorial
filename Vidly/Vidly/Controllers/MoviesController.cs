using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            return View(GetMovies());
        }
        // GET: Movies



        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie() {Name = "Shrek"},
                new Movie() {Name = "Wall-E"},

            };
        }


        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}