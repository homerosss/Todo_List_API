using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class Registration : User
    {
        public Registration(string name, string email, string password) : base (name, email, password)
        {
            
        }

        public string RegistrationUsername(string username)
        {
            throw new ArgumentException();
        }

        public string UsernameExist()
        {
            throw new ArgumentException();
        }
    }
}
