using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal abstract class BaseRegistration :  User , IUserRegistration
    {
        protected static User[]? _users;

        public BaseRegistration()
        {
            _users = new User[0];
        }

        public abstract void RegistrationSuccess(User username);

        protected abstract bool UserIsExists(string? username);

        protected abstract int GetEmptyIndex();

        protected abstract int GetIndexByUser(string? username);

        protected abstract bool IsFull();
    }
}
