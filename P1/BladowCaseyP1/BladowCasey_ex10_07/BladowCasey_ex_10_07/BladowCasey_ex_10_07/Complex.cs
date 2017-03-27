using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex_10_07
{
    public class Complex
    {
        public double real;
        public double imaginary;

        public Complex(double r, double i)
        {
            setReal(r);
            setImaginary(i);
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
        public void Add(Complex c)
        {
            real += c.getReal();
            imaginary += c.getImaginary();
        }

        //subtracts real and imaginary numbers
        public void Subtract(Complex c)
        {
            real -= c.getReal();
            imaginary -= c.getImaginary();
        }

        //outputs values as string
        public String ToString()
        {
            return "(" + real + "," + imaginary + ")";
        }
    }
}
