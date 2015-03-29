using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.Write( "Enter a : " );
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter h : ");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;

            Console.WriteLine("Trapezoid's area: " + area);

        }
    }
}
