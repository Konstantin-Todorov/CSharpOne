//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2 3
//5	1 2 3 4 5

using System;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("You`ve entered a negative intiger !");

            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);

                }
            }Console.WriteLine();
        }
    }
}
