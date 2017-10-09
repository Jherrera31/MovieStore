using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index()
        {
            List<Artist> lista = new List<Artist>();
            var artist1 = new Artist()
            {
                Id=1,
                Name="Jose",
                LastName="Jose",
                Age=74
            };
            var artist2 = new Artist()
            {
                Id = 2,
                Name = "Juan Luis",
                LastName = "Guerra",
                Age = 60
            };
            var artist3 = new Artist()
            {
                Id = 3,
                Name = "Romeo",
                LastName = "Santos",
                Age = 40
            };

            lista.Add(artist1);
            lista.Add(artist2);
            lista.Add(artist3);
            return View(lista);
        }
    }
}