//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter radius : ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * (double) Math.PI * r;
            double area = (double) Math.PI * r * r;

            Console.WriteLine("Perimeter : {0:f2}",perimeter);
            Console.WriteLine("Area : {0:f2}",area);

        }
    }
}
