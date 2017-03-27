using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BladowCasey_ex04_12;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 14.95M);

            // display invoice1
            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part number: {0}", invoice1.PartNumber);
            Console.WriteLine("Description: {0}",
               invoice1.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice1.Quantity);
            Console.WriteLine("Price: {0:C}", invoice1.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}",
               invoice1.GetInvoiceAmount());

            // change invoice1's data
            invoice1.PartNumber = "001234";
            invoice1.PartDescription = "Yellow Hammer";
            invoice1.Quantity = 3;
            invoice1.PricePerItem = 19.49M;

            // display invoice1 with new data
            Console.WriteLine("\nUpdated invoice information");
            Console.WriteLine("Part number: {0}", invoice1.PartNumber);
            Console.WriteLine("Description: {0}",
               invoice1.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice1.Quantity);
            Console.WriteLine("Price: {0:C}", invoice1.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}",
               invoice1.GetInvoiceAmount());

            Invoice invoice2 = new Invoice("5678", "PaintBrush", -5, -9.99M);

            // display invoice2
            Console.WriteLine("\nOriginal invoice information");
            Console.WriteLine("Part number: {0}", invoice2.PartNumber);
            Console.WriteLine("Description: {0}",
               invoice2.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice2.Quantity);
            Console.WriteLine("Price: {0:C}", invoice2.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}",
               invoice2.GetInvoiceAmount());

            // change invoice2's data
            invoice2.Quantity = 3;
            invoice2.PricePerItem = 9.49M;

            // display invoice2 with new data
            Console.WriteLine("\nUpdated invoice information");
            Console.WriteLine("Part number: {0}", invoice2.PartNumber);
            Console.WriteLine("Description: {0}",
               invoice2.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice2.Quantity);
            Console.WriteLine("Price: {0:C}", invoice2.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}",
               invoice2.GetInvoiceAmount());

            Console.Read();
        }
    }
}
