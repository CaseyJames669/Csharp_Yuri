using System;
namespace BladowCasey_ex_10_09
{
    interface IRational
    {
        Rational Divide(Rational right);
        Rational Multiply(Rational right);
        Rational Subtract(Rational right);
        Rational Sum(Rational right);
        string ToFloatString(int digits);
        string ToString();
    }
}
