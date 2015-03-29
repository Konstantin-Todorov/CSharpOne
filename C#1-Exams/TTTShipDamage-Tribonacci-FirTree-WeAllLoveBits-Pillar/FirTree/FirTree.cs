using System;

class FirTree
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int width = 2*N-2;
        //firstline
        Console.Write(new String('.', N - 2));
        Console.Write("*");
        Console.WriteLine(new String('.', N - 2));
        //middle
        int dots = N - 2;
        for (int i = 1; i < N-1; i++)
        {
            
            int asteriks2 = i;
            int asteriks = i+1;
            dots--;
            Console.Write(new String('.', dots));
            Console.Write(new String ('*',asteriks));
            Console.Write(new String ('*',asteriks2 ));
            Console.WriteLine(new String('.',dots));
            asteriks+=2;
        }
        //lastline
        Console.Write(new String('.', N - 2));
        Console.Write("*");
        Console.Write(new String('.', N - 2));
    }
}

