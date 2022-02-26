using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Renter.Database;
using Renter.Models;
using Renter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Renter.Controllers
{
    public class MoviesController : Controller
    {
        public Context _context;

        public MoviesController()
        {
            _context = new Context();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if(movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}

