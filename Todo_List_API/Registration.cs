using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    public class Registration : User 
    {
        protected static List<User> _users = new List<User>();

        public Registration()
        {
        }
        
        public static void RegistrationSuccess(User username)
        {
            ValidateUser.IfExists(username);
            _users.Add(username);
        }
    }
}
