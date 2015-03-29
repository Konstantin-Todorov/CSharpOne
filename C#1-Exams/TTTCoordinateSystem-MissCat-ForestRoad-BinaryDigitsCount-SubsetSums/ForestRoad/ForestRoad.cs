using System;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int height = N * 2 - 1;
            int lenght = N % 2;
            int secondDots = N / 2 + 1;
            //first part
            for (int i = 1; i < N; i++)
            {
                Console.Write(new String('.', i));
                Console.Write("*");
                Console.WriteLine(new String('.', N - i - 1));
            }
            // second part
            for (int i = N - 2; i >= 0; i--)
            {
                Console.Write(new String('.', i));
                Console.Write("*");
                Console.WriteLine(new String('.', N - i - 1));
            }
        }
    }
}
//using System;

//namespace Problem_3_Forest_Road
//{
//    class Problem_3_Forest_Road
//    {
//        static void Main()
//        {
//            // Read input
//            int N = int.Parse(Console.ReadLine());

//            // Write first part
//            for (int i = 0; i < N - 1; i++)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    if (i != j)
//                    {
//                        Console.Write(".");
//                    }
//                    else
//                    {
//                        Console.Write("*");
//                    }
//                }
//                Console.WriteLine();
//            }

//            // Write second part
//            for (int i = N - 1; i >= 0; i--)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    if (i != j)
//                    {
//                        Console.Write(".");
//                    }
//                    else
//                    {
//                        Console.Write("*");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}