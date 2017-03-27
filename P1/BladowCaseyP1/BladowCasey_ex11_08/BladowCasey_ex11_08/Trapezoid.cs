using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BladowCasey_ex11_08
{
    public class Trapezoid : Quadrilateral
    {
        public Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            //throw new System.NotImplementedException();

        }
    
        public double GetArea()
        {
            //throw new System.NotImplementedException();
            return GetSumOfTwoSides() * GetHeight() / 2.0;
        }

        public double GetHeight()
        {
            //throw new System.NotImplementedException();
            if (Point1.Y == Point2.Y)
                return Math.Abs(Point2.Y - Point3.Y);
            else
                return Math.Abs(Point1.Y - Point2.Y);
        }

        public double GetSumOfTwoSides()
        {
            //throw new System.NotImplementedException();
            if (Point1.Y == Point2.Y)
                return Math.Abs(Point1.X - Point2.X) + Math.Abs(Point3.X - Point4.X);
            else
                return Math.Abs(Point2.X - Point3.X) + Math.Abs(Point4.X - Point1.X);
        }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\n{0}:\n{1}{2}: {3}\n{4}: {5}\n", "Coordinates of Trapezoid are", GetCoordinatesAsString(), "Height is", GetHeight(), "Area is", GetArea());
        }
    }
}
