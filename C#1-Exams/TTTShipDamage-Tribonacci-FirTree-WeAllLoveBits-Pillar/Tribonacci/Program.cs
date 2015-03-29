using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        BigInteger result = 0;

        if (N == 1)
        {
            Console.WriteLine(firstNumber);
        }
        if (N == 2)
        {
            Console.WriteLine(secondNumber);
        }
        if (N == 3)
        {
            Console.WriteLine(thirdNumber);
        }
        else
        {
            for (int i = 4; i <= N; i++)
            {
                result = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = result;
            }
            Console.WriteLine(result);
        }
    }
}
