//Namirane dali 2 chisla sa ednakvi i kogato ima chislo koeto nqma ednkavo s samoto nego se prinitira
//samoto chislo!
using System;

namespace OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            string read = Console.ReadLine();
            long N = long.Parse(read);
            long currentNum = 0;
            long result = 0;
            for (int i = 0; i < N; i++)
            {
                read = Console.ReadLine();
                currentNum = long.Parse(read);
                result ^= currentNum;
            }
            Console.WriteLine(result);
        }
    }
}
