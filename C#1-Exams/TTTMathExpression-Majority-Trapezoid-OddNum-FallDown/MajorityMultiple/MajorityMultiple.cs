using System;
namespace MajorityMultiple
{
    class MajorityMultiple
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int result = 0;
            int number = 1;
            while (result == 0)
            {
                int count = 0;
                if (number % a ==0)
                {
                    count++;
                }
                if (number % b == 0)
                {
                    count++;
                }
                if (number % c == 0)
                {
                    count++;
                }
                if (number % d == 0)
                {
                    count++;
                }
                if (number % e == 0)
                {
                    count++;
                }
                if (count>=3)
                {
                    result = number;
                }
                number++;
            }
            Console.WriteLine(result);
        }
    }
}
