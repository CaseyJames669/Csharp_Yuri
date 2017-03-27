using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BladowCasey_ex11_08
{
    public class Parallelogram : Trapezoid
    {
        public Parallelogram(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4) { }
    
    public double GetWidth()
    {
        if (Point1.Y == Point2.Y)
            return Math.Abs(Point1.X - Point2.X);
        else
            return Math.Abs(Point2.X - Point3.X);
    }
    public override string ToString()
    {
        return string.Format("\n{0}:\n{1}{2}: {3}\n{4}: {5}\n{6}: {7}\n", "Coordinates of Parallelogram are", GetCoordinatesAsString(), "Width is", GetWidth(), "Height is", GetHeight(), "Area is", GetArea());
    }
     
}
}
