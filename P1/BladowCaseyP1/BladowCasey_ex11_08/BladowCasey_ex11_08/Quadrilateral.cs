using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BladowCasey_ex11_08
{
    public class Quadrilateral
    {
        public Quadrilateral(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            //throw new System.NotImplementedException();
            Point1 = new Point(x1, y1);
            Point2 = new Point(x2, y2);
            Point3 = new Point(x3, y3);
            Point4 = new Point(x4, y4);
        }
    
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public Point Point3 { get; private set; }
        public Point Point4 { get; private set; }

        public string GetCoordinatesAsString()
        {
            //throw new System.NotImplementedException();
            return string.Format("{0}, {1}, {2}, {3}\n", Point1, Point2, Point3, Point4);
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Coordinates of Quadrilateral are:\n{0}", GetCoordinatesAsString());
        }

    }
}
