using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public class Cube : ThreeDimensionalShape
    {
        public Cube(int x, int y, int side) : base(x, y, side, side, side) { }
        public override string Name
        {
            get
{
    return "Cube";
}
        }
        public override double Area
        {
            get
            {
                return (6 * Side * Side);
            }
        }
        public override double Volume
        {
            get
            {
                return (Side * Side * Side);
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
                Dimension3 = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}: {2}\n", base.ToString(), "side", Side);
        }//end method ToString
    }//end class Cube

}
