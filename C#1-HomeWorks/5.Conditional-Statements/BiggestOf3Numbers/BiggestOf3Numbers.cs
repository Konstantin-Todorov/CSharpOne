//Write a program that finds the biggest of three numbers.
using System;
using System.Globalization;
using System.Threading;

namespace BiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture=CultureInfo.InstalledUICulture;

            Console.WriteLine("Please, enter three numbers : ");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double biggest = a;
            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }

            Console.WriteLine("The biggest is :  {0}", biggest);
        }
    }
}
