﻿using System;
using System.Linq;

namespace Excercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charset1 = { 'X', 'Y', 'Z' };
            int[] numset1 = { 1, 2, 3 };
            string[] colorset1 = { "Green", "Orange" };

            Console.Write("\nLINQ : Generate a Cartesian Product of three sets : ");
            Console.Write("\n----------------------------------------------------\n");

            var cartesianProduct = from letter in charset1
                                   from number in numset1
                                   from colour in colorset1
                                   select new { letter, number, colour };

            Console.Write("The Cartesian Product are : \n");
            foreach (var ProductList in cartesianProduct)
            {
                Console.WriteLine(ProductList);
            }
            Console.ReadLine();
        }
    }
}
