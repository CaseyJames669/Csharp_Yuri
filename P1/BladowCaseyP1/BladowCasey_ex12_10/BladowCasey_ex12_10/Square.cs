using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public class Square : TwoDimensionalShape
    {
        public Square(int x, int y, int side) : base(x, y, side, side) { }
        public override string Name
        {
            get
{
    return "Square";
}
        }
        public override double Area
        {
            get
            {
                return (Side * Side);
            }
        }
        public int Side
        {
            get
            {
                return Dimension1;
            }
            set
            {
                Dimension1 = value;
                Dimension2 = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}: {2}\n", base.ToString(), "side", Side);
        }//end method ToString
    }//end class Square

}
