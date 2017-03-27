using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDistinctWords
{
    class LINQDistinctWords
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("Please enter a sentence: ");
            string sentence = Console.ReadLine();//read input
            string[] words = sentence.Split();//split sentence into words

            //use LINQ to sort the words and convert to lowercase
            var sortedWords =
                from word in words
                let lowerCaseWord = word.ToLower()
                orderby lowerCaseWord
                select lowerCaseWord;

            Console.WriteLine(" \nYou entered: ");//display header
            Console.WriteLine(sentence);//display the input
            Console.Write("\nDistinct Words: ");//display header

            //display only distinct words
            foreach (var word in sortedWords.Distinct())
                Console.Write("{0} ", word);

            Console.WriteLine();

            Console.Read();

        }
    }
}
