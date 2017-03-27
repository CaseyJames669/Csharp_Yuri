using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_CustomExceptions
{
    public class Class1
    {
        static void Main(string [] args)
        {
        double value1 = 0,
            value2 = 0,
            answer;
        try
        {
        answer = GetResults(value1, value2);
        }
        catch (FloatingPointException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch 
        {
            Console.Error.WriteLine("some error");
        }
        finally
        {
            Console.Read();
        }
        }
        static double GetResults(double v1, double v2)
        {
            if (v2 < 0.000001)
            {
                FloatingPointException exceptObj =
                    new FloatingPointException("Exception Type: " +
                "Floating-point division by zero");
                throw exceptObj;
            }
        return v1/v2;
        }
    }
}
