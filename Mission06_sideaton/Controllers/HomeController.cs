using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_sideaton.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sideaton.Controllers
{
    public class HomeController : Controller
    {
        private MovieDatabaseContext _movieContext { get; set; }

        public HomeController(MovieDatabaseContext someName)
        {
            _movieContext = someName;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(response);
                _movieContext.SaveChanges();
                return View("Confirmation", response);
            }
            else //If values are invalid
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(response);
            }
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            // ordering the list by year and sending them to the view
            var movies = _movieContext.responses
                .Include(cat => cat.Category)
                .OrderBy(x => x.MovieYear)
                .ToList();
            return View(movies);
        }
        // allows the movies to be edited
        [HttpGet]
        public IActionResult Edit(int MovieID)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            var movie = _movieContext.responses.Single(x => x.MovieID == MovieID);
            return View("Movies", movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie res)
        {
            _movieContext.Update(res);
            _movieContext.SaveChanges();
            // instead of retyping in all the data, it redirects to the action
            return RedirectToAction("MovieList");
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
