using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    public abstract class BaseRegistration :  User , IUserRegistration
    {
        protected static List<User> _users = new List<User>();

        public BaseRegistration()
        {

        }

        public abstract void RegistrationSuccess(User username);
    }
}
