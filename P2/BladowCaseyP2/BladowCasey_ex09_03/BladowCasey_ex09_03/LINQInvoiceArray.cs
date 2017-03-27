using System;
using System.Collections.Generic;
using System.Linq;

namespace BladowCasey_ex09_03
{
    public class LINQInvoiceArray
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = {
            new Invoice( 83, "Electric sander", 7, 57.98M ),
            new Invoice( 24, "Power saw      ", 18, 99.99M ),
            new Invoice( 7,  "Sledge hammer  ", 11, 21.5M ),
            new Invoice( 77, "Hammer         ", 76, 11.99M ),
            new Invoice( 39, "Lawn mower     ", 3, 79.5M ),
            new Invoice( 68, "Screwdriver    ", 106, 6.99M ),
            new Invoice( 56, "Jig saw        ", 21, 11M ),
            new Invoice( 3,  "Wrench         ", 34, 7.5M ) }; // end initializer list

            // use LINQ to sort invoices by description
            var sortedByDescription =
                from item in invoices // item can be any name as long as it hasnt been used
                orderby item.PartDescription //partdescription was in the list
                select item;

            // display invoices, sorted by description
            Console.WriteLine("Sorted by description:");
            foreach (var item in sortedByDescription)
                Console.WriteLine(item);

            // use LINQ to sort invoices by price
            var sortedByPrice =
                 from item in invoices // item can be any name as long as it hasnt been used
                 orderby item.Price
                 select item;

            // display invoices, sorted by price
            Console.WriteLine("\nSorted by price:");
            foreach (var item in sortedByPrice)
                Console.WriteLine(item);

            // use LINQ to select description and quantity, sort by quantity
            var sortedByQuantity =
                  from item in invoices // item can be any name as long as it hasnt been used
                  orderby item.Quantity
                  select new { item.PartDescription, item.Quantity };

            // display description and quantity, sorted by quantity
            Console.WriteLine("\nSelect description and quantity, sort by quantity:");
            foreach (var item in sortedByQuantity)
                Console.WriteLine("{0} {1}", item.PartDescription, item.Quantity);

            // use LINQ to select description and calculated
            // invoice total; sort by invoice total
            var descripQuanity =
                from item in invoices
                let total = item.Quantity * item.Price

                orderby total
                select new { item.PartDescription, total };


            // display description and calculated invoice total
            Console.WriteLine("\nSelect description and invoice total, sort by invoice total:");
            foreach (var item in descripQuanity)
                Console.WriteLine("{0} {1}", item.PartDescription, item.total);

            // use LINQ to filter previous query results on range of totals
            var sortTotal =
            from item in invoices
            let total = item.Quantity * item.Price
            where total <= 500 && total >= 200
            orderby total ascending
            select new { item.PartDescription, total };

            // display filtered descriptions and invoice totals
            Console.WriteLine(string.Format("\nInvoice totals between {0:C} and {1:C}:", 200, 500));
            foreach (var item in sortTotal)
                Console.WriteLine("{0}\t {1}", item.PartDescription, item.total);

            //Console.WriteLine();
        } // end Main
    } // end class LINQInvoiceArray
}