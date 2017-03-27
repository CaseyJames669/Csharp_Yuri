using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public abstract class TwoDimensionalShape : Shape
    {
        public int Dimension1 { get; set; }
        public int Dimension2 { get; set; }
        public TwoDimensionalShape(int x, int y, int d1, int d2)
            : base(x, y)
        {
            Dimension1 = d1;
            Dimension2 = d2;
        }
        public abstract double Area
        {
            get;
        }
    }//end class TwoDimensionalShape
}
