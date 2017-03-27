using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex_10_09
{
    public class Rational : BladowCasey_ex_10_09.IRational
    {
        private int numerator;
        private int denominator;

        public Rational()
        {
            numerator = 1;
            denominator = 1;
        }

        //initialize n and d
        public Rational(int num, int den)
        {
            numerator = num;
            denominator = den;
            reduce();
        }

        //addition
        public Rational Sum(Rational right)
        {
            return new Rational(numerator * right.denominator + denominator * right.numerator, denominator * right.denominator);
        }

        //subtraction
        public Rational Subtract(Rational right)
        {
            return new Rational(numerator * right.denominator - denominator * right.numerator, denominator * right.denominator);
        }

        //Multiplcation
        public Rational Multiply(Rational right)
        {
            return new Rational(numerator * right.numerator, denominator * right.denominator);
        }

        //division
        public Rational Divide(Rational right)
        {
            return new Rational(numerator * right.denominator, denominator * right.numerator);
        }

        //reduce the fraction
        private void reduce ()
        {
            int gcd = 0; //greatest common denominator
            int smaller;

            //find the GCD of the 2 numbers
            if (numerator < denominator)
                smaller = numerator;
            else
                smaller = denominator;

            for (int divisor = smaller; divisor >= 2; divisor--)
            {
                if (numerator % divisor == 0 && denominator % divisor == 0)
                {
                    gcd = divisor;
                    break;
                }
            }

            //divide by the GCD
            if (gcd != 0)
            {
                numerator /= gcd;
                denominator /= gcd;
            }
        }

        //return String
        public String ToString()
        {
            return numerator + "/" + denominator;
        }

        //return floating-point
        public String ToFloatString(int digits)
        {
             double value = (double)numerator / denominator;
             //tells how to format the floating point
             return String.Format("{0:F" + digits + "}", value);
             //return value.ToString();
        }
    }
}
