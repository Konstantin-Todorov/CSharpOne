//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;


namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter a :");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b :");
            double b = double.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("{0} is greater than {1}",a,b);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}",b,a);
            }

        }
    }
}
