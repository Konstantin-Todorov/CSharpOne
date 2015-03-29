//...*****...
//..*..*..*..
//.*...*...*.
//***********
//.*...*...*.
//..*..*..*..
//...*.*.*...
//....***....
//.....*.....

using System;

namespace DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main()
        {
            // int n = int.Parse(Console.ReadLine());
            int n = 5;
            int width = n * 2 + 1;
            int height = 6 + ((n - 3) / 2) * 3;

            string firstLineDots = new String('.', (width - n) / 2);
            string firstLineStars = new String('*', n);
            Console.WriteLine("{0}{1}{0}", firstLineDots, firstLineStars);
            for (int row = 0; row < height / 3 - 1; row++)
            {
                int dotsCount = (width - 3) / 4 - row;
                string endsDots = new String('.', dotsCount);
                string middleDots = new String('.', (width - 2 * dotsCount - 3) / 2);
                Console.WriteLine("{0}*{1}*{1}*{0}", endsDots, middleDots);
            }

            string middleSymbols = new String('*', n * 2 - 1);
            Console.WriteLine("*{0}*", middleSymbols);

            int middleDotsCounts = n - 2;
            for (int row = 0; row < n; row++)
            {
                int begginingDotsCount = row + 1;
                string begginingDots = new String('.', begginingDotsCount);
                if (middleDotsCounts >= 0)
                {
                    string middleDots = new String('.', middleDotsCounts);
                    Console.WriteLine("{0}*{1}*{1}*{0}", begginingDots, middleDots);
                    middleDotsCounts--;
                }
                else
                {
                    Console.WriteLine("{0}*{0}", begginingDots);
                }

            }
        }
    }
}


