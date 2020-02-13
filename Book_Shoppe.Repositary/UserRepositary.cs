using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Shoppe.Data;
namespace Book_Shoppe.Repositary
{
    public static class UserRepositary
    {
        public static List<User> userList = new List<User>();

        static UserRepositary()
        {
            // var user = new User() { Name = "Bathri!",UserName="Bathri",MailID="bathri@gmail.com"};
            userList.Add(new User {Name="Bathri",UserName= "Bathri",MailID= "bathri@gmail.com",Role= "Admin" });
            userList.Add(new User {Name= "Vinoth", UserName="Vinoth",MailID="vinoth@gmail.com", Role="Customer" });
            userList.Add(new User {Name="Ragav", UserName="Ragav",MailID= "ragav@gmail.com",Role= "Seller" });
        }
        public static IEnumerable<User> GetAllUsers()
        {
            return userList;
        }
    }
}
