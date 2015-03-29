using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a positive integer N: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            if (!(i % 3 == 0 || i % 7 == 0))
            {
                Console.Write(i);
                if (i < N)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}