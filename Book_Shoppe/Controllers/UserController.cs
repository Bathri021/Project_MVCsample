using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Book_Shoppe.Models;
namespace Book_Shoppe.Controllers
{
    public class UserController : Controller
    {
        // GET: User/UserDetails
        public ActionResult UserDetails()
        {
             List<User> userList = new List<User>();
            // var user = new User() { Name = "Bathri!",UserName="Bathri",MailID="bathri@gmail.com"};
            userList.Add(new User("Bathri","Bathri","bathri@gmail.com","Admin"));
            userList.Add(new User("Vinoth", "Vinoth", "vinoth@gmail.com", "Customer"));
            userList.Add(new User("Ragav", "Ragav", "ragav@gmail.com", "Seller"));

            UserDetail objUserDetails = new UserDetail();
            objUserDetails.UserDetails = userList;
            return View(objUserDetails);
        }

        // GET: User/Edit/id
        public ActionResult Edit(int id)
        {
            return Content("ID = "+id);
        }
    }
}