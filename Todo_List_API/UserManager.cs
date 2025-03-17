using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    public class UserManager : User 
    {
        protected static List<User> _users = new();

        public static void Registration(User createAccount)
        {
            ValidateUser.IfExists(createAccount);
            _users.Add(createAccount);
        }

        public static void DeleteAccount(User deleteAccount)
        {
            ValidateUser.IfExists(deleteAccount);
            _users.Remove(deleteAccount);
        }

        public static void ChangeAccountPassword(User password)
        {
            ValidateUser.IfExists(password);
            _users.Remove(password);
        }
    }
}
