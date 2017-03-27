using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BladowCasey_ex_10_09;

namespace ConsoleApplication1
{
    class RationalTest
    {
        static void Main(string[] args)
        {
            int numerator; // the numerator of a fraction
            int denominator; // the denominator of a fraction
            int digits; // digits to display in floating point format
            Rational rational1; // the first rational number
            Rational rational2; // second rational number
            Rational result; // result of performing an operation

            // read first fraction
            Console.Write("Enter numerator 1: ");
            numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator 1: ");
            denominator = Convert.ToInt32(Console.ReadLine());
            rational1 = new Rational(numerator, denominator);

            // read second fraction
            Console.Write("Enter numerator 2: ");
            numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator 2: ");
            denominator = Convert.ToInt32(Console.ReadLine());
            rational2 = new Rational(numerator, denominator);

            Console.Write("Enter precision (digits): ");
            digits = Convert.ToInt32(Console.ReadLine());

            int choice = GetMenuChoice(); // user's choice in the menu

            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        result = rational1.Sum(rational2);
                        Console.WriteLine("a + b = {0} = {1}",
                           result.ToString(),
                           result.ToFloatString(digits));
                        break;
                    case 2:
                        result = rational1.Subtract(rational2);
                        Console.WriteLine("a - b = {0} = {1}",
                           result.ToString(),
                           result.ToFloatString(digits));
                        break;
                    case 3:
                        result = rational1.Multiply(rational2);
                        Console.WriteLine("a * b = {0} = {1}",
                           result.ToString(),
                           result.ToFloatString(digits));
                        break;
                    case 4:
                        result = rational1.Divide(rational2);
                        Console.WriteLine("a / b = {0} = {1}",
                           result.ToString(),
                           result.ToFloatString(digits));
                        break;
                } // end switch

                choice = GetMenuChoice();
            } // end while
        } // end Main

        // displays a menu and returns the chosen value
        private static int GetMenuChoice()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit\n");
            Console.Write("Choice: ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
