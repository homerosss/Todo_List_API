using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class User
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;

        public int  Id { get => _id; private set => _id = value; }
        public string Name { get => _name; private set => _name = value; }
        public string Email { get => _email; private set => _email = value; }
        public string Password { get => _password; private set => _password = value; }
    }
}
