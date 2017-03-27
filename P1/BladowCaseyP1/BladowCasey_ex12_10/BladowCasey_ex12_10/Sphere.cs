using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex12_10
{
    public class Sphere : ThreeDimensionalShape
    {
        public Sphere(int x, int y, int radius) : base(x, y, radius, radius, radius) { }
        public override string Name
        {
            get
{
    return "Sphere";
}
        }
        public override double Area
        {
            get
            {
                return (4 * Math.PI * Radius * Radius);
            }
        }
        public override double Volume
        {
            get
            {
                return (4.0 / 3.0 * Math.PI * Radius * Radius * Radius);
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
                Dimension3 = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}: {2}\n", base.ToString(), "radius", Radius);
        }//end method ToString
    }//end class Sphere

}
