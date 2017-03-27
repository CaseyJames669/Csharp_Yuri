using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex20_07
{
    public class GenericLinearSearch
    {
        public static int DisplayArray<T>(T[] inputArray, T value)
        where T : IComparable<T>
        {
            int i = 0;
            foreach (T element in inputArray)
            {

                if (element.CompareTo(value) == 0)
                {
                    return i;
                }

                i++;
            }
            return -1;
        }
    }
}
