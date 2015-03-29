using System;
class PeaceOfCake
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long D = long.Parse(Console.ReadLine());
        long denominator = B * D;
        A = A * D;
        C = C * B;
        long sum = A + C;
        decimal fraction = sum / denominator;
        if (fraction >= 1)
        {
            long peace = sum / denominator;
            Console.WriteLine("{0}", peace);
            Console.WriteLine("{0}/{1}",sum,denominator);
        }
        else 
        {
            decimal peace = (decimal)sum / (decimal)denominator;
            Console.WriteLine("{0:F22}",peace);
            Console.WriteLine("{0}/{1}", sum, denominator);
        }
    }
}

