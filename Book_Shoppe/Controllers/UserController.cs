using Book_Shoppe.Data;
using Book_Shoppe.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book_Shoppe.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Index
        public ActionResult Index()
        {
            ViewBag.userCount = UserRepositary.getUserCount();
            return View();
        }

        //[HttpGet]
        //public ActionResult Register()
        //{
        //    ViewBag.userCount = UserRepositary.getUserCount();
        //    return View();
        //}
        [HttpPost]
        public ActionResult Register()
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                //UpdateModel(user);
                TryUpdateModel(user);
                UserRepositary.Add(user);
                ViewBag.Message = "Registration Successfull";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Users()
        {
            IEnumerable<User> users = UserRepositary.GetAllUsers();
            return View(users);
        }

        //[HttpPost]
        //public ActionResult Register(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        UserRepositary.Updata(user);
        //        TempData["Message"] = "Added Successfully";
        //    }
        //    return View(user);
        //}
    }
}