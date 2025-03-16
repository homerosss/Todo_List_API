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

        public int  Id { get => _id; private set => _id = value; }
        public string? Name { get => _username; private set => _username = value; }
        public string? Email { get => _email; private set => _email = value; }
        public string? Password { get => _password; private set => _password = value; }

        public User()
        {
            
        }

        public User(int id, string? username, string? email, string? password)
        {
            Id = id;
            Name = username;
            Email = email;
            Password = password;

        }
    }
}
