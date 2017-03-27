using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex_10_08
{
    interface IIntegerSet
    {
        void DeleteElement(int deleteInteger);
        void InsertElement(int insertInteger);
        IntegerSet Intersection(IntegerSet integerSet);
        bool IsEqualTo(IntegerSet integerSet);
        string ToString();
        IntegerSet Union(IntegerSet integerSet);
    }
}
