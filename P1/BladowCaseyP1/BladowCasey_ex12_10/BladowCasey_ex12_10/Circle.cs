using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public class Circle : TwoDimensionalShape
    {
        public Circle(int x, int y, int radius) : base(x, y, radius, radius) { }
        public override string Name
        {
            get
{
    return "Circle";
}
        }
        public override double Area
        {
            get
            {
                return (Math.PI * Radius * Radius);
            }
        }
        public int Radius
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
            return string.Format("{0} {1}: {2}\n", base.ToString(), "radius", Radius);
        }//end method ToString
    }//end class Circle


}
