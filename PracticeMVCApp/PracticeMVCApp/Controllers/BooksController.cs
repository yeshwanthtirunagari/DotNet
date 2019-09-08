using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeMVCApp.Models;

namespace PracticeMVCApp.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/Random
        public ActionResult Random()
        {
            Books books = new Books();
            for (int i = 0; i < 2; i++)
            {
                books.BookName = "Clean Code" ;
            }

            return View(books);
        }
    }
}