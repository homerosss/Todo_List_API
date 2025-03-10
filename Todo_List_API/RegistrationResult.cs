using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class RegistrationType : User
    {
        enum RegistrationResult
        {
            Success,
            DataNotProvided,
            UserAlreadyExists,
            DataBaseIsFull
        }
    }
}
