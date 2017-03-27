using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BladowCasey_ex12_10;

namespace ClientConsole
{
    class ShapeTest
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(22, 88, 4);
            shapes[1] = new Square(71, 96, 10);
            shapes[2] = new Sphere(8, 89, 2);
            shapes[3] = new Cube(79, 61, 8);

            ShapePolyClass.ShapePoly(shapes);
        }
    }
}
