﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BladowCasey_ex12_10;

namespace ClientConsole
{
    public class ShapePolyClass
    {
        public static void ShapePoly(Shape[] shapes)
        {
            // call method ToString on all shapes
            foreach (var currentShape in shapes)
            {
                Console.Write("{0}: {1}",
                   currentShape.Name, currentShape);

                if (currentShape is TwoDimensionalShape)
                {
                    TwoDimensionalShape twoDimensionalShape =
                       (TwoDimensionalShape)currentShape;

                    Console.WriteLine("{0}'s area is {1}",
                       currentShape.Name, twoDimensionalShape.Area);
                } // end if

                if (currentShape is ThreeDimensionalShape)
                {
                    ThreeDimensionalShape threeDimensionalShape =
                       (ThreeDimensionalShape)currentShape;

                    Console.WriteLine("{0}'s area is {1}",
                       currentShape.Name, threeDimensionalShape.Area);
                    Console.WriteLine("{0}'s volume is {1}",
                       currentShape.Name,
                       threeDimensionalShape.Volume);
                } // end if

                Console.WriteLine();

            } // end foreach

            Console.Read();
        }
    }
}
