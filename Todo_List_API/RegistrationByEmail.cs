using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class RegistrationByEmail : BaseRegistration
    {
        public RegistrationByEmail() : base()
        {

        }

        public override void RegistrationSuccess(User username)
        {
            throw new NotImplementedException();
        }
    }
}
