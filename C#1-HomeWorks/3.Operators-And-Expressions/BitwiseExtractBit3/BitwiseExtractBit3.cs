using System;
namespace BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int mask = (number >> 3) & 1;

            Console.WriteLine(Convert.ToString(mask, 2));
        }
    }
}
