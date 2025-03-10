using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class User
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }

        public User() { }
        public User(int id) { }
        public User(string name, string email) { }

        public User(string name, string email, string password) { }


    }
}
