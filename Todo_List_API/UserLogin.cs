﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class UserLogin : Registration
    {
        public static void Access(User user)
        {
            ValidateUser.IfUserRegistered(user);
            Console.WriteLine($"Welcome");
        }
    }
}
