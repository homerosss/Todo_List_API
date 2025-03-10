using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class Registration : User
    {
        private User[]? _users; 
        public Registration()
        {
            _users = new User[10];
        }

        public void RegistrationUsername(User username)
        {
            if(username == null) throw new ArgumentNullException("Username is null");
            if (username.Name.Length == 0) throw new ArgumentException($"Username must be minimum 6 letters");
            if (isFull) throw new ArgumentNullException();

            int index = GetEmptyIndex(username);
            _users[index] = username;
        }

        public void UsernameExist(User username)
        {

        }

        public int GetIndexByUsername(string username)
        {
            for(int i = 0; i < _users.Length; i++)
            {
                if (_users[i].Name == username)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetEmptyIndex(User userName)
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

        private bool isFull()
        {
            for(int i = 0; i < _users.Length; i++)
            {
                if (_users[i] != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
