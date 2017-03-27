using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public abstract class Shape : BladowCasey_ex12_10.IShape
    {
        public int X {get; set;}
        public int Y {get; set;}
        public Shape (int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        public abstract string Name
        {
            get;
        }
    }
}
