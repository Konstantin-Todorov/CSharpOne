//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:

//input	output
//3 
//2 
//5 
//1	min = 1 
//max = 5 
//sum = 8 
//avg = 2.67





using System;
using System.Threading;
using System.Globalization;


namespace minmaxsumandaverageofnnumbers
{
    class minmaxsumandaverageofnnumbers
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            for (int i = 0, number; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (min > number)
                {
                    min = number;

                }
                if (max < number)
                {
                    max = number;
                }
                sum += number;

            }
            Console.WriteLine("min {0} \n" +
                "max {1} \n" +
                "sum {2} \n" +
                "avg {3}", min, max, sum, sum / n);

        }
    }
}
