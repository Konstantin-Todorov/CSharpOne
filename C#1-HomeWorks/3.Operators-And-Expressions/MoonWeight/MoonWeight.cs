using System;

namespace MoonWeight
{
    class MoonWeight
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight : ");
            double weight = double.Parse(Console.ReadLine());
            double weightMoon = weight * 0.17;

            Console.WriteLine("Your weight on the moon is : " + weightMoon);
        }
    }
}
