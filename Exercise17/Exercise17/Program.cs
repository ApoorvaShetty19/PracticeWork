using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listofString = new List<string>();
            listofString.Add("m");
            listofString.Add("n");
            listofString.Add("o");
            listofString.Add("p");
            listofString.Add("q");
            Console.Write("\nLINQ: Remove Items from List using remove function :");
            Console.Write("\n------------------------------------------------");
            var _result1 = from y in listofString select y;
            Console.Write("Here is the list of items added");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }
            string newstr = listofString.FirstOrDefault(en => en == "o");
            listofString.Remove(newstr);
            var _result = from z in listofString select z;
            Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Console.ReadLine();
        }
    }
}