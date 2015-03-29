using System;

//10

//..........**********
//.........*.........*
//........*..........*
//.......*...........*
//......*............*
//.....*.............*
//....*..............*
//...*...............*
//..*................*
//.*.................*
//********************


namespace Trapezoid
{
    class Trapezoid
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int widthTop = N;
            int widthBottom = N * 2;
            Console.Write(new String('.', widthTop));
            Console.WriteLine(new String ('*',N));
            int secondHalfDots = N;
            for (int i = 0; i < N-1; i++)
            {
                Console.Write(new String ('.',widthTop-1));
                Console.Write("*");
                Console.Write(new String ('.',secondHalfDots-1));
                Console.WriteLine("*");
                secondHalfDots++;
                widthTop--;
            }
            Console.WriteLine(new String('*',widthBottom));
        }
    }
}
