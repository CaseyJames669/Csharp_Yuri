using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BladowCasey_ex_10_08;

namespace ConsoleApplication1
{
    class IntegerTest
    {
        static void Main(string[] args)
        {
            // initialize two sets
            Console.WriteLine("Input Set A");
            IntegerSet set1 = InputSet();
            Console.WriteLine("\nInput Set B");
            IntegerSet set2 = InputSet();

            IntegerSet union = set1.Union(set2);
            IntegerSet intersection = set1.Intersection(set2);

            // prepare output
            Console.WriteLine("\nSet A contains elements:");
            Console.WriteLine(set1.ToString());
            Console.WriteLine("\nSet B contains elements:");
            Console.WriteLine(set2.ToString());
            Console.WriteLine(
               "\nUnion of Set A and Set B contains elements:");
            Console.WriteLine(union.ToString());
            Console.WriteLine(
               "\nIntersection of Set A and Set B contains elements:");
            Console.WriteLine(intersection.ToString());

            // test whether two sets are equal
            if (set1.IsEqualTo(set2))
                Console.WriteLine("\nSet A is equal to set B");
            else
                Console.WriteLine("\nSet A is not equal to set B");

            // test insert and delete
            Console.WriteLine("\nInserting 77 into set A...");
            set1.InsertElement(77);
            Console.WriteLine("\nSet A now contains elements:");
            Console.WriteLine(set1.ToString());

            Console.WriteLine("\nDeleting 77 from set A...");
            set1.DeleteElement(77);
            Console.WriteLine("\nSet A now contains elements:");
            Console.WriteLine(set1.ToString());

            // test constructor
            int[] intArray = { 25, 67, 2, 9, 99, 105, 45, -5, 100, 1 };
            IntegerSet set3 = new IntegerSet(intArray);

            Console.WriteLine("\nNew Set contains elements:");
            Console.WriteLine(set3.ToString());

            Console.Read();

        }

        private static IntegerSet InputSet()
        {
            IntegerSet temp = new IntegerSet();

            Console.Write("Enter number (-1 to end): ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != -1)
            {
                temp.InsertElement(number);

                Console.Write("Enter number (-1 to end): ");
                number = Convert.ToInt32(Console.ReadLine());
            } // end while

            return temp;
        } // end method InputSet

    }
}
