using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Shoppe.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string MailID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // Declare a User Properties
        public User(string name,string userName,string mailID,string role)
        {
            this.Name = name;
            this.UserName = userName;
            this.MailID = mailID;
            this.Role = role;
        }
    }

    // Declare a User List In a Class
    public class UserDetail
    {
        public List<User> UserDetails {get;set;}
    }
}