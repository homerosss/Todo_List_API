using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    public class ValidateUser : Registration
    {
        public static void IfExists(User user)
        {
            foreach (var existedUsers in _users)
            {
                if (user?.Name == existedUsers.Name)
                {
                    throw new Exception($"User with Username: {user?.Name} already exists");
                }
                if (user?.Email == existedUsers.Email)
                {
                    throw new Exception($"User with E-Mail: {user?.Email} already exists");
                }
                if (user?.Id == existedUsers.Id)
                {
                    throw new Exception($"User with ID: '{user?.Id}' already exists");
                }
                if(user?.Password?.Length > 15 && user?.Password.Length < 4)
                {
                    throw new Exception($"Enter password correctly");
                }
            }
        }

        public static void IfUserRegistered(User users)
        {
            bool isFound = false;
            foreach (var registered in _users)
            {
                if(registered.Name == users.Name && registered.Email == users.Email && registered.Password == users.Password)
                {
                    isFound = true;
                }
                else { isFound = false; }
            }
            if (!isFound)
            {
                throw new ArgumentException($"Username: {users.Name}, Email: {users.Email} or Password: {users.Password} is incorrect");
            }
        }
    }
}
