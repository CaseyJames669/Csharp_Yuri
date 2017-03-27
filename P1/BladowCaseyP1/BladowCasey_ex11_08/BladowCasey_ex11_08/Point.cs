using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BladowCasey_ex11_08
{
    public class Point : IPoint
    {
        public Point(double xCoordinate, double yCoordinate)
        {
            //throw new System.NotImplementedException();
            X = xCoordinate;
            Y = yCoordinate;
        }
        // read-only property that gives x-coordinate
        public double X { get; private set; }

        // read-only property that gives yCoordinate-coordinate
        public double Y { get; private set; }
        //representation of the point object
        public override string ToString()
        {
            return string.Format("( {0:F1},{1:F2} )", X, Y);
        }
        
    }
}
