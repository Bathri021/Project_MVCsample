using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Book_Shoppe.Data;
using Book_Shoppe.Repositary;

namespace Book_Shoppe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            IEnumerable<Book> books = BookRepositary.GetAllBooks();
            return View(books);
        }

        public ActionResult Users()
        {
            IEnumerable<User> users = UserRepositary.GetAllUsers();
            return View(users);
        }

        public ActionResult Books()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Views()
        {
            IEnumerable<Book> booksList = BookRepositary.GetAllBooks();
            IEnumerable<User> usersList = UserRepositary.GetAllUsers();
            ViewBag.books = booksList;
            ViewData["Users"] = usersList;
            return View();
        }
    }
}