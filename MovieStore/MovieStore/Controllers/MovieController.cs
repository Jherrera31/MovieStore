using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<Movie> lista = new List<Movie>();
            Movie mov1= new Movie();
            mov1.Id = 18;
            mov1.Title = "God";
            mov1.Description = "Peace";
            mov1.Rating = 1;
            lista.Add(mov1);

            Movie mov2 = new Movie();
            mov2.Id = 19;
            mov2.Title = "Minion";
            mov2.Description = "aventure";
            mov2.Rating = 2;
            lista.Add(mov2);

            Movie mov3 = new Movie();
            mov3.Id = 20;
            mov3.Title = "Amazing women";
            mov3.Description = "Accion";
            mov3.Rating = 3;
            lista.Add(mov3);

            Movie mov4 = new Movie();
            mov4.Id = 21;
            mov4.Title = "My Bestfriend";
            mov4.Description = "Romantic";
            mov4.Rating = 4;
            lista.Add(mov4);

            return View(lista);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
