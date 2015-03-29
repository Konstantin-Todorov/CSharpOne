//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
using System.Threading;
using System.Globalization;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter five numbers separated by a space : ");
            string[] numbers = Console.ReadLine().Split(' ');
            double sumOfNumbers = 0;

            if (numbers.Length < 5)
            {
                Console.WriteLine("\nEnter more numbers (5) !");
            }
            else if (numbers.Length > 5)
            {
                Console.WriteLine("\nEnter less numbers (5) !");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfNumbers += double.Parse(numbers[i]);
            }

            Console.WriteLine("\nSum of all numbers: {0}\n", sumOfNumbers);
        }
    }
}
