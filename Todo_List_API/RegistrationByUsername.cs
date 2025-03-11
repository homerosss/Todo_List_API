using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class RegistrationByUsername : BaseRegistration
    {
        private static User[]? _users; 
        public RegistrationByUsername()
        {
            _users = new User[10];
        }

        public void RegistrationUsername(User username)
        {
            if(username.Name == null) throw new ArgumentNullException("Username is null");
            if (username == null) throw new ArgumentNullException("Username is null");
            if (username.Name.Length == 0) throw new ArgumentException($"Username must be minimum 6 letters");
            if (IsFull()) throw new SemaphoreFullException("List is full");
            if (UsernameExist(username.Name)) throw new ArgumentException("Username already exists");

            int index = GetEmptyIndex();
            _users[index] = username;
            Console.WriteLine("Registration Success");
        }

        public bool UsernameExist(string username)
        {
            return GetIndexByUsername(username) != -1;
        }



        public static int GetIndexByUsername(string username)
        {
            for(int i = 0; i < _users.Length; i++)
            {
                if (_users[i]?.Name == username)
                {
                    return i;
                }
            }
            return -1;
        }

        public static User? GetUserByUsername(string username)
        {
            int index = GetIndexByUsername(username);
            return index != -1 ? _users[index] : null;
        }
        private static int GetEmptyIndex()
        {
            for(int i = 0; i < _users.Length; i++)
            {
                if (_users[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        private bool IsFull()
        {
            return GetEmptyIndex() == -1;
        }
    }
}
