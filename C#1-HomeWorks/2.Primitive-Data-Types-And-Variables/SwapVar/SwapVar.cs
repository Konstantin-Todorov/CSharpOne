/*using System;

namespace SwapVar
{
    class SwapVar
    {
        static void Main()
        {
            int var1 = 5;
            int var2 = 10;
            Console.WriteLine("Before the exchange: " + var1 , ",\n" + var2);
            Swap<int>(ref var1, ref var2);

        }

        private static void Swap<T1>(ref int var1, ref int var2)
        {
            throw new NotImplementedException();
        }
    }
}*/

// or

using System;

namespace SwapVar
{
    class SwapVar
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Variable a = " + a + ", Variable b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After value exchange: a = " + a + ", b = " + b);
            
        }
    }
}