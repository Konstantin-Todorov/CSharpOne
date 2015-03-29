using System;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
           for (int i = 3, j = 24; i < 6; i++, j++)
             {
                if (((number >> i) & 1) != ((number >> j) & 1))
                
                {
                    number = ChangeBits(number, i, j);
            
                }
            
             }
            Console.WriteLine("Result: " + number);
        }

        private static int ChangeBits(int number, int firstPosition, int secondPosition)
        
        
        {
            number ^= (1 << firstPosition);
            return number ^ (1 << secondPosition);
        }
    }
}

