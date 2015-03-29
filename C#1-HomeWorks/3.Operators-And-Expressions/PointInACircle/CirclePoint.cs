using System;
namespace PointInACircle
{
    class CirclePoint
    {
        static void Main()
        {
            Console.Write("Enter x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            double y = double.Parse(Console.ReadLine());
            int r = 2;
            bool inside = r * r > (Math.Pow((0 - x), 2)) + (Math.Pow((0 - x), 2));

            Console.Write("The point is inside the circle : ");
            Console.WriteLine(inside);
        }
    }
}
