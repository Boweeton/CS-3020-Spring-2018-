using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queryTesting2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Up front declarations
            Random rng = new Random();
            List<char> charList = new List<char>();

            // Fill the list with random letters
            for (int i = 0; i < 1000; i++)
            {
                charList.Add((char)rng.Next('A', 'Z' + 1));
            }

            // LINQ Query to sort decending
            var qList0 =
                from qChar in charList
                orderby qChar descending
                select qChar;

            // LINQ Query to sort acending
            var qList1 =
                from qChar in charList
                orderby qChar
                select qChar;

            // LINQ Query to sort acending
            var qList2 =
                (from qChar in charList
                orderby qChar
                select qChar).Distinct();

            // Print the list
            foreach (char c in qList2)
            {
                Console.WriteLine(c);
            }
        }
    }
}