using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_CustomExceptions
{
    public class FloatingPointException : ApplicationException 
    {
        public FloatingPointException(string exeptionType) :
            base(exeptionType)
        {
            //empty body
        }
    }
}
