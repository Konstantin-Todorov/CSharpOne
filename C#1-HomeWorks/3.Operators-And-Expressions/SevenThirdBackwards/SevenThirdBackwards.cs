using System;

namespace SevenThirdBackwards
{
    class SevenThirdBackwards
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            bool isSeven = false;

            number = number % 1000;
            number /= 100;

            if (number == 7)
            {
                Console.WriteLine(!isSeven);
            }
            else
            {
                Console.WriteLine(isSeven);
            }
        }
    }
}
