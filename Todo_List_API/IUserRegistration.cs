using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    public interface IUserRegistration
    {
         abstract void RegistrationSuccess(User username);
    }
}
