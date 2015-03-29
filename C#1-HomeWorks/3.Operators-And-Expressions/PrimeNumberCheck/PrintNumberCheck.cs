using System;

namespace PrimeNumberCheck
{
    class PrintNumberCheck
    {
        static void Main()
        {
            Console.Write("Please enter an integer >= 2: ");
            int input = Convert.ToInt32(Console.ReadLine());
            bool isPrime = false;
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    isPrime = true;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(input + " is prime.");
            }
            else
            {
                Console.WriteLine(input + " is not prime.");
                
            }
        }
    }
}