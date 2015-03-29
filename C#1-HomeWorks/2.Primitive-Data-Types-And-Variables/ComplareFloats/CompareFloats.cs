using System;
namespace ComplareFloats
{
    class CompareFloats
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;

            Console.WriteLine("The numbers are{0}equal.", equal ? " " : " NOT EQUAL ");
        }
    }
}
