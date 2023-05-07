using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Data;
using Vena.Models;
using Vena.Services;
using Vena.ViewModels;

namespace Vena.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _service;
        private readonly VenaDbContext _context;

        public MovieController(IMovieService service, VenaDbContext context)
        {
            _service = service;
            _context = context;
        }
        // GET: MovieController
        public ActionResult Index()
        {
            return View(_service.List());
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View(viewModel);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieFormViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Add(viewModel);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
