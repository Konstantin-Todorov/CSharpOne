using System;

namespace ModifyBitsPosition
{
    class ModifyBitsPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a position : ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value : ");
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                int mask = ~(1 << position);
                number = number & mask;
            }
            else
            {
                int mask = 1 << position;
                number = number | mask;
            }

            Console.WriteLine(number);
        }
    }
}
