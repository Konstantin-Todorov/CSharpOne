//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

namespace _01SumOf3Numbers
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter a real number \"a\" : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a real number \"b\" : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a real number \"c\" : ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of \"a\" + \"b\" + \"c\" is : {3} ", a, b, c, (a + b + c));
        }
    }
}

