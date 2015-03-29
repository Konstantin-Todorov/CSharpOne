using System;
namespace NullValues
{
    class Program
    {
        static void Main()
        {
            int? nullInteger = null;
            Console.WriteLine("This is a integer with a null value:" + nullInteger);
            double? nullDouble = null;
            Console.WriteLine("This is a double with a null value:" + nullDouble);

            nullInteger = 20;
            Console.WriteLine("This is a integer with value 20");
            nullDouble = 7.6;
            Console.WriteLine("This is a double with value 20");
            
            int? value = null;
            Console.WriteLine(value.GetValueOrDefault());

        }
    }
}
