using System;

namespace TribonacciTriangle
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            long trib = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    trib = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = trib + firstNumber + secondNumber;
                    Console.Write(trib);
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                } Console.WriteLine();
            } 
        }
    }
}
