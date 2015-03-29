using System;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter number to check: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is {0}.", IsEven(number) ? "EVEN" : "ODD");
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 1) return false;
            return true;
        }
    }
}
