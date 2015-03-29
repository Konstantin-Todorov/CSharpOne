using System;

namespace CheckBitsPosition
{
    class CheckBitsPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a position: ");
            int position = int.Parse(Console.ReadLine());
            bool isOne = true;
            int mask = (number >> position) & 1;

            if (mask == 1)
            {
                Console.WriteLine(isOne);
            }
            else
            {
                Console.WriteLine(!isOne);
            }
        }
    }
}
