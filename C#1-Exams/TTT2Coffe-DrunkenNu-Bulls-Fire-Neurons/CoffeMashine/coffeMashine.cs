using System;
using System.Threading;
using System.Globalization;

namespace CoffeMashine
{
    class coffeMashine
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InstalledUICulture;

            int firstTray = int.Parse(Console.ReadLine());
            int secondTray = int.Parse(Console.ReadLine());
            int thirdTray = int.Parse(Console.ReadLine());
            int fourthTray = int.Parse(Console.ReadLine());
            int fifthTray = int.Parse(Console.ReadLine());
            decimal amountPut = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            if (price>amountPut)
            {
                decimal difference = price - amountPut;
                Console.WriteLine("More {0:F2}" , difference);
            }
            else 
            {
                decimal moneyTrays=
                    0.05m * fifthTray +
                    0.10m * secondTray +
                    0.20m * thirdTray + 
                    0.50m * fourthTray + 
                    1.00m * fifthTray;
                decimal difference = amountPut - price;
                decimal change = Math.Abs(moneyTrays - difference);

                if (amountPut>=price)
                {
                    Console.WriteLine("Yes {0:F2}",change);
                }
                else
                {
                    Console.WriteLine("No {0:F2}",change);
                }
            }
        }
    }
}
