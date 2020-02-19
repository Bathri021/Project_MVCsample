using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shoppe.Data
{
    public class User
    {
        [Required]
        public int UserID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string MailID { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        [DisplayName("Role")]
        [Required]
        public int RoleID { get; set; }

        public RoleViewModel RoleModel { get; set; }

        public User()
        {

        }
        // Declare a User Properties
        //public User(string name, string userName, string mailID, string role)
        //{
        //    this.Name = name;
        //    this.UserName = userName;
        //    this.MailID = mailID;
        //    this.Role = role;
        //}
    }

    public class RoleViewModel
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }

    public class FormUserViewModel
    {
        public IEnumerable<RoleViewModel> Role;
        public User user;
    }
}
