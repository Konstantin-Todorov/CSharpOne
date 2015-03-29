//B is the secret Number! 

using System;
namespace _3_6_9
{
    class Program
    {
        static void Main()
        {
            long firstNumber = int.Parse(Console.ReadLine());
            long code = long.Parse(Console.ReadLine());
            long secondNumber = int.Parse(Console.ReadLine());
            long result = 0;

            switch (code)
            {
                case 3: result = firstNumber + secondNumber;
                    break;
                case 6: result = firstNumber * secondNumber;
                    break;
                case 9: result = firstNumber % secondNumber;
                    break;
            }
            if (result % 3 == 0 )
            {
                Console.WriteLine("{0}",result / 3);
            }
            else 
            {
                Console.WriteLine("{0}",result % 3);
            }
            Console.WriteLine("{0}",result);
        }
    }
}
