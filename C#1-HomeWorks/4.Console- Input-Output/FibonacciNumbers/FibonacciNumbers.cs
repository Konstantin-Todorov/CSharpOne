//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
using System;
namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {

            Console.Write("Please enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, number);

        }

        public static void Fibonacci(int a, int b, int counter, int number)

        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
    }
}

