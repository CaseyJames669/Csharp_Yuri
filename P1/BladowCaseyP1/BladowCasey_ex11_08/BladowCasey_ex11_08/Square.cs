using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BladowCasey_ex11_08
{
    public class Square : Rectangle
    {
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4) { }

        public override string ToString()
        {
            return string.Format("\n{0}:\n{1}{2}: {3}\n{4}: {5}\n", "Coordinates of a square are", GetCoordinatesAsString(), "Side is", GetHeight(), "Area is", GetArea());
        }
    }
}
