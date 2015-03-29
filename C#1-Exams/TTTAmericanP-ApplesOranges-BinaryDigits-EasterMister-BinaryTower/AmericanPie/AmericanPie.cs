//smqtane na parcheta pai
using System;
using System.Threading;
using System.Globalization;

class AmericanPie
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long firstNominator = long.Parse(Console.ReadLine());
        long firstDenominator = long.Parse(Console.ReadLine());
        long secondNominator = long.Parse(Console.ReadLine());
        long secondDenominator = long.Parse(Console.ReadLine());

        long resultNominator = firstNominator * secondDenominator + secondNominator * firstDenominator;
        long resultDenominator = firstDenominator * secondDenominator;
        decimal result = ((decimal)resultNominator / resultDenominator);

        if (result >= 1)
        {
            Console.WriteLine((long)result);
        }
        else
        {
            Console.WriteLine("{0:F20}", result);
        }
        Console.WriteLine(resultNominator + "/" + resultDenominator);
    }
}

