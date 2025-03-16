using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class RegistrationByEmail : BaseRegistration
    {
        public override void RegistrationSuccess(User username)
        {
        }

        protected override bool UserIsExists(string? username)
        {
            return false;
        }



        protected override int GetIndexByUser(string? username)
        {
            return 0;
        }

        public User? GetUserByUsername(string username)
        {
            return null;
        }
        protected override int GetEmptyIndex()
        {
            return 0;
        }

        protected override bool IsFull()
        {
            return GetEmptyIndex() == -1;
        }
    }
}
