using System;

namespace Rectangular
{
    class Rectangular
    {
        static void Main()
        {
            Console.Write("Enter width : ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height : ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + height * 2;
            double area = width * height;

            Console.WriteLine("Rectangle’s perimeter is: " + perimeter);
            Console.WriteLine("Rectangle’s area is: " + area);
        }
    }
}
