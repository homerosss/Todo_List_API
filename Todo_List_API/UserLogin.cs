using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class UserLogin : RegistrationByUsername
    {
        private static User?[] _users = new User?[10];
        public static bool Login(string username, string password)
        {
            User? user = GetUserByUsername(username);
            return user?.Password == password;
        }

        public static bool UnRegister(string username)
        {
            int index = GetIndexByUsername(username);
            if (index != -1)
            {
                _users[index] = null;
                return true;
            }
            return false;
        }
    }
}
