//pazaruvane na qbulki i portukali
using System;

namespace ApplesAndOranges
{
    class ApplesAndOranges
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                n = -n;
            }
            int oddDigitsSum = 0;
            int evenDigitsSum = 0;
            while (n>0)
            {
                int digit = n % 10;

                if (digit%2==0)
                {
                    evenDigitsSum += digit;
                }
                else
                {
                    oddDigitsSum += digit;
                }
                n /= 10;
            }
            int difference = oddDigitsSum - evenDigitsSum;
            if (difference >0)
            {
                Console.WriteLine("apples {0}",evenDigitsSum);
            }
            else if (difference < 0)
            {
                Console.WriteLine("oranges {0}",oddDigitsSum);
            }
            else
            {
                Console.WriteLine("both",evenDigitsSum);
            }
        }
    }
}
