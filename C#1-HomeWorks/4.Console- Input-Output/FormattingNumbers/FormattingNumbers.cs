//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Globalization;
using System.Threading;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter an integer number between 0 and 500.\na : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a floating-point number.\nb : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please, enter a floating-point number.\nc : ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------\nResult : ");
            Console.WriteLine("\n{0,-5:X}|{1}|{2,8:F2}|{3,-7:F3}|\n", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

        }
    }
}
