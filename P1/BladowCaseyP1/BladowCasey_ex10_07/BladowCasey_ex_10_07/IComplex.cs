using System;
namespace BladowCasey_ex_10_07
{
    interface IComplex
    {
        Complex Add(Complex right);
        double getImaginary();
        double getReal();
        void setImaginary(double i);
        void setReal(double r);
        Complex Subtract(Complex right);
        string ToString();
    }
}
