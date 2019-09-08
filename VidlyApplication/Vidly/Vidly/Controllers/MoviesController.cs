using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.MyPrograms;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        PrimeNumbers pn = new PrimeNumbers();
        
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies() {name = "Kung Fu Panda"};

            // return HttpNotFound();
            return View(movie);
            //return Content("Hello World!");
           // return new EmptyResult();
           // return RedirectToAction("Index" , "Home" ,  new { page = 1 , sortBy = "name"});
        }

        // GET : Movies
        public ActionResult Index(int? id, string Mname)
        {
            if (!id.HasValue)
                id = 1;
            if (string.IsNullOrEmpty(Mname))
            Mname = "DefaultName";

            return Content(String.Format("id = {0} and Name = {1}" , id , Mname));
        }

        // GET: Movies/Edit
        public ActionResult Edit(int Id)
        {
            string value = pn.Prime(Id);
            return Content(String.Format("Id is: {0} and {1} " , Id , value));
        }
    }
}