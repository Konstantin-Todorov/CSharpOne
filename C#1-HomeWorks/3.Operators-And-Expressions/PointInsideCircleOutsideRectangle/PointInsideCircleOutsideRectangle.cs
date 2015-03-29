using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            Console.Write("Enter x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            bool insideK = r * r > (Math.Pow((x - 1), 2)) + (Math.Pow((y - 1), 2));
            bool outsideR = x >= -1 && x <= 4 && y >= -1 && y <= 1;

            Console.Write("The point is inside the circle and outside the rectangle :  ");
            if (insideK && !outsideR)
            
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
