using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC823.Models;

namespace TestMVC823.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals/Random
        public ActionResult Random()
        {
            Animals animals = new Animals() {AnimalName = "Tiger" };

           // return Content("Hello Tiger");

          //  return RedirectToAction("Index" , "Home" , new { paper = 1 , cake = "Pineapple" });

          //  return HttpNotFound();

           return View(animals);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " +id);
        }

        // GET : Animals
        public ActionResult Index(int? PageIndex , string sortBy)
        {

            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";           


            return Content(String.Format("PageIndex is {0} and sortby is {1}" , PageIndex , sortBy));
        }
    }
}