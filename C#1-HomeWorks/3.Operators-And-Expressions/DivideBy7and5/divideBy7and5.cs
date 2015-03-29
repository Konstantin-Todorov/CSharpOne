using System;

namespace DivideBy7and5
{
    class divideBy7and5
    {
        static void Main()
        {
            Console.WriteLine("Enter as number : ");
            int number = int.Parse(Console.ReadLine());
            bool isDivided = false;

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Not divided" , !isDivided);
            }
            else
            {
                Console.WriteLine("Divided" , isDivided);
            }
        }
    }
}

