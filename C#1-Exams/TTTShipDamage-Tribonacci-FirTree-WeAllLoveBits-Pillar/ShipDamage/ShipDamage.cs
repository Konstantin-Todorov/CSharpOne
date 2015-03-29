using System;

namespace ShipDamage
{
    class ShipDamage
    {
        static void Main()
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());

            int by1 = (h - cy1) + h;
            int by2 = (h - cy2) + h;
            int by3 = (h - cy3) + h;

            int demage = 0;

            // check corners
            if ((by1 == sy1 && cx1 == sx1) || (by1 == sy2 && cx1 == sx1) || (by1 == sy1 && cx1 == sx2) || (by1 == sy2 && cx1 == sx2))
            {
                demage += 25;
            }

            if ((by2 == sy1 && cx2 == sx1) || (by2 == sy2 && cx2 == sx1) || (by2 == sy1 && cx2 == sx2) || (by2 == sy2 && cx2 == sx2))
            {
                demage += 25;
            }

            if ((by3 == sy1 && cx3 == sx1) || (by3 == sy2 && cx3 == sx1) || (by3 == sy1 && cx3 == sx2) || (by3 == sy2 && cx3 == sx2))
            {
                demage += 25;
            }

            // check sides
            if (((cx1 == sx1 || cx1 == sx2) && by1 < Math.Max(sy1, sy2) && by1 > Math.Min(sy1, sy2)) ||
                (by1 == sy1 || by1 == sy2) && cx1 < Math.Max(sx1, sx2) && cx1 > Math.Min(sx1, sx2))
            {
                demage += 50;
            }

            if (((cx2 == sx1 || cx2 == sx2) && by2 < Math.Max(sy1, sy2) && by2 > Math.Min(sy1, sy2)) ||
                (by2 == sy1 || by2 == sy2) && cx2 < Math.Max(sx1, sx2) && cx2 > Math.Min(sx1, sx2))
            {
                demage += 50;
            }

            if (((cx3 == sx1 || cx3 == sx2) && by3 < Math.Max(sy1, sy2) && by3 > Math.Min(sy1, sy2)) ||
                (by3 == sy1 || by3 == sy2) && cx3 < Math.Max(sx1, sx2) && cx3 > Math.Min(sx1, sx2))
            {
                demage += 50;
            }

            //is in boundaries of ship
            if (cx1 < Math.Max(sx1, sx2) && cx1 > Math.Min(sx1, sx2) && (by1 < Math.Max(sy1, sy2) && by1 > Math.Min(sy1, sy2)))
            {
                demage += 100;
            }

            if (cx2 < Math.Max(sx1, sx2) && cx2 > Math.Min(sx1, sx2) && (by2 < Math.Max(sy1, sy2) && by2 > Math.Min(sy1, sy2)))
            {
                demage += 100;
            }

            if (cx3 < Math.Max(sx1, sx2) && cx3 > Math.Min(sx1, sx2) && (by3 < Math.Max(sy1, sy2) && by3 > Math.Min(sy1, sy2)))
            {
                demage += 100;
            }

            Console.WriteLine(demage + "%");
        }
    }
}
