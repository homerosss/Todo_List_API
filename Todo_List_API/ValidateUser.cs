using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_API
{
    internal class ValidateUser
    {
        public ValidateUser() { }
        public ValidateUser(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
        }
    }
}
