using System;
namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a position : ");
            int position = int.Parse(Console.ReadLine());
            int mask = (number >> position) & 1;

            Console.WriteLine(mask);
        }
    }
}
