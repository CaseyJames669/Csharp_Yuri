using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public abstract class ThreeDimensionalShape : Shape
    {
        public int Dimension1 { get; set; }
        public int Dimension2 { get; set; }
        public int Dimension3 { get; set; }
        public ThreeDimensionalShape(int x, int y, int d1, int d2, int d3)
            : base(x, y)
        {
            Dimension1 = d1;
            Dimension2 = d2;
            Dimension3 = d3;
        }
        public abstract double Area
        {
            get;
        }
        public abstract double Volume
        {
            get;
        }
    }//end class ThreeDimensionalShape
}
