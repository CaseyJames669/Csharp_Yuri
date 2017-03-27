using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey__ex13_10
{
    public class MilesPerGallon
    {
        public static void Main(string[] args)
        {
            string quit;

            do
            {
                try
                {
                    Console.Write("Enter miles driven: ");
                    double miles = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter gallons used: ");
                    double gallonsUsed = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Miles Per Gallon: " + CalculateMPG(miles, gallonsUsed));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("wrong format" + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Divide by zero. Please emter decimal numbers for "+
                        "the miles driven and gallons used." + ex.Message);
                }

                Console.Write("Quit (y/n)? ");
                quit = Console.ReadLine().ToLower();
            } while (quit != "y");
        }
        private static double CalculateMPG(double milesDriven, double gallonsUsed)
        {
            if (gallonsUsed < 0.0000001)
                throw new DivideByZeroException();
            return milesDriven / gallonsUsed;
        }
    }
}
