//matematicheski izraz

using System;
using System.Globalization;
using System.Threading;
namespace MathExpression
{
    class MathExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double nominatorNum = 1337;
            double denominarNum = 128.523123123;
            double firstPart = N * N + 1 / (M * P) + nominatorNum;
            double secondPart = N - denominarNum * P;
            double thirdPart = Math.Sin((int)M % 180);
            double result = firstPart / secondPart + thirdPart;
            Console.WriteLine("{0:F6}",result);

        }
    }
}
