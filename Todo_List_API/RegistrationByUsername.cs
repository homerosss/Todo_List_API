﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class RegistrationByUsername : BaseRegistration
    {
        
        public RegistrationByUsername()
        {

        }

        public override void RegistrationSuccess(User username)
        {
            if(username.Name == null) throw new ArgumentNullException("Username is null");
            if (username == null) throw new ArgumentNullException("Username is null");
            if (username.Name.Length == 0) throw new ArgumentException($"Username must be minimum 6 letters");
            if (IsFull()) throw new SemaphoreFullException("List is full");
            if (UserIsExists(username.Name)) throw new ArgumentException("Username already exists");

            int index = GetEmptyIndex();
            _users[index] = username;
            Console.WriteLine("Registration Success");
        }

        protected override bool UserIsExists(string? username)
        {
            return GetIndexByUser(username) != -1;
        }



        protected override int GetIndexByUser(string? username)
        {
            for(int i = 0; i < _users?.Length; i++)
            {
                if (_users[i]?.Name == username)
                {
                    return i;
                }
            }
            return -1;
        }

        public User? GetUserByUsername(string? username)
        {
            int index = GetIndexByUser(username);
            return index != -1 ? _users?[index] : null;
        }
        protected override int GetEmptyIndex()
        {
            for(int i = 0; i < _users?.Length; i++)
            {
                if (_users[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        protected override bool IsFull()
        {
            return GetEmptyIndex() == -1;
        }
    }
}
