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
            ViewBag.Roles = new SelectList(UserRepositary.GetRoles(), "RoleID", "RoleName");
            return View();
        }

 
        [HttpPost]
        public ActionResult Register([Bind(Include ="UserID,Name,UserName,MailID,Password,RoleID")] User user)
        {
            if(!ModelState.IsValid){
                return View("Index", user);
            }
                UserRepositary.Add(user);
                ViewBag.Message = "Registration Successfull";
                ViewBag.Roles = new SelectList(UserRepositary.GetRoles(), "RoleID", "RoleName");
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