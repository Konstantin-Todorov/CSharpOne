﻿//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int counter = 0;

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write("{0} ", col + counter);
            }

            Console.WriteLine();
            counter++;
        }

        Console.ReadLine();
    }
}
