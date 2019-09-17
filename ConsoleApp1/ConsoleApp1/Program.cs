using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            Console.Write("\n LINQ:Find the uppercase words in a string:");
            Console.Write("\n-----------------------\n");
            string strNew;
            Console.Write("Input the string:");
            strNew = Console.ReadLine();
            var ucWord = WordFilt(strNew);
            Console.Write("\n The UPPER CASE words are:\n");
            foreach (string strRet in ucWord)
            {
                Console.WriteLine(strRet);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal));

            return upWord;

        }
    }
}