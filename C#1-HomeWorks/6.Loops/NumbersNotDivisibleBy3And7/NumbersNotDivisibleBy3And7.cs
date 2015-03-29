﻿//ite a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2
//10	1 2 4 5 8 10
using System;

namespace NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
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
                    if (!(i % 3==0 || i % 7==0))
                    {
                        Console.Write("{0} ", i);
                    }
                    

                }
            } Console.WriteLine();
        }
    }
}
