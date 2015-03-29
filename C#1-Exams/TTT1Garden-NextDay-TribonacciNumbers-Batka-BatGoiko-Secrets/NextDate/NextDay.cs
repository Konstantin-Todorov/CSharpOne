using System;
namespace NextDay

{
    class NextDay
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime input = new DateTime(year, month, day);
            Console.WriteLine("{0:d.M.yyyy}", input.AddDays(1));
        }
    }
}
