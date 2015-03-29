//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

namespace Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three numbers : ");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());


            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("Sort numbers : {0} {1} {2}", a, b, c);
                }
                else 
                {
                    Console.WriteLine("Sort numbers : {0} {2} {1}", a, b, c);

                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Sort numbers : {0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Sort numbers : {0} {2} {1}", b, a, c);
                }

            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Sort numbers : {0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("Sort numbers : {0} {2} {1}", c, b, a);
                }
            }
        }
    }
}
