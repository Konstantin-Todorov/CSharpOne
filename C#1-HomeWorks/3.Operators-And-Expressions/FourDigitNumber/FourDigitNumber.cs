using System;
namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a four digit number : ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number % 10000;
            firstDigit /= 1000;

            int secondDigit = number % 1000;
            secondDigit /= 100;

            int thirdDigit = number % 100;
            thirdDigit /= 10;

            int fourDigit = number % 10;
            fourDigit /= 1;

            int sum = firstDigit + secondDigit + thirdDigit + fourDigit;

            Console.WriteLine("Sum of digits: " + sum);
            Console.WriteLine("Reversed: {3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourDigit);
            Console.WriteLine("Last digit in front: {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourDigit);
            Console.WriteLine("Second and third digits exchanged: {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourDigit);
        }
    }
}
