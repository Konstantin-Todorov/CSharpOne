//After Z you get AA, AB, AC etc. until you get to AZ. Then it is BA, BB, BC, …, ZY, ZZ, AAA, AAB, …, AAZ, ABA, …, ZZY, ZZZ, AAAA, AAAB and so on… The last column is ZZZZZZZZZZ.
using System;
using System.Numerics;

namespace ExcelColumns
{
    class ExcelColumns
    {
        static void Main()
        {
            BigInteger result = 0;
            int baseValue = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = n-1; i >= 0; i--)
            {
                char letters = char.Parse(Console.ReadLine());
                baseValue = letters - 64;
                BigInteger pow = (BigInteger)Math.Pow(26, i);
                result += (BigInteger)baseValue * pow;
            }
            Console.WriteLine(result);
        }
    }
}
