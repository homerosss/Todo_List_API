using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    public class User
    {
        private int _id;
        private string? _username;
        private string? _email;
        private string? _password;

        public User()
        {

        }

        public User(int id, string? name, string? email, string? password) : this()
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public int Id { get => _id; private set => _id = value; }
        public string? Name { get => _username; private set => _username = value; }
        public string? Email { get => _email; private set => _email = value; }
        public string? Password { get => _password; private set => _password = value; }
    }
}
