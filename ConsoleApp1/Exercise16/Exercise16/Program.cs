using System;
using System.IO;
using System.Linq;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirfiles = Directory.GetFiles("C:/Project1/Exercise16");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
            avgFsize = Math.Round(avgFsize / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avgFsize);
            Console.ReadLine();
        }
    }
}
