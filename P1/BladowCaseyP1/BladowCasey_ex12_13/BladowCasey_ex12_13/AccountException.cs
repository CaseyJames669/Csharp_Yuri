using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_13
{
    public class AccountException : ApplicationException
    {
        public AccountException(string message) : base (message)
        {
            //empty body
        }
    }
}
