using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex_10_07
{
    public class Complex : IComplex
    {
        private double real;
        private double imaginary;

        public Complex(double r, double i)
        {
            real = r;
            imaginary = i;
        }

        //if nothing is passed, zero (0) is used.
        public Complex()
        {
            setReal(0);
            setImaginary(0);
        }

        //returns real value
        public double getReal()
        {
            return real;
        }

        //sets real value
        public void setReal(double r)
        {
            real = r;
        }

        //returns imaginary value
        public double getImaginary()
        {
            return imaginary;
        }

        //sets imaginary value
        public void setImaginary(double i)
        {
            imaginary = i;
        }

        //adds real and imaginary numbers
        public Complex Add(Complex right)
        {
            return new Complex(real + right.real,
                imaginary + right.imaginary);
        }

        //subtracts real and imaginary numbers
        public Complex Subtract(Complex right)
        {
            return new Complex(real - right.real,
                imaginary - right.imaginary);
        }

        //outputs values as string
        public override string ToString()
        {
            return (System.String.Format("({0}, {1})", real, imaginary));
        }
    }
}
