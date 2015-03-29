using System;

namespace TelerikLogo
{
    class TelerikLogo
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int width = (X + X) + ((X / 2) + 1 + ((X / 2) + 1) - 3);
            int hornslength = X / 2;
            int middleDots = width - 2*(X / 2 + 1);
                Console.Write(new String('.',hornslength));
                Console.Write("*");
                Console.Write(new String('.',middleDots));
                Console.Write("*");
                Console.WriteLine(new String('.',hornslength));
            middleDots -=2;
            int firstHornDots = X / 2 - 1;
            int lastHornDots = 0;
            for (int i = 1; i < X-1; i++)
			{
                if (i<=X/2)
                {
                    Console.Write(new String('.',firstHornDots));
                    Console.Write("*");
                    Console.Write(new String('.',lastHornDots));
                    
                }
                else 
                {
                    Console.Write(new String('.',hornslength));
                }
                Console.Write(new String('.', i));
                Console.Write("*");
                Console.Write(new String('.',middleDots));
                Console.Write("*");
                Console.Write(new String('.', i));
                if (i<=X/2)
                {
                    Console.Write(new String('.', lastHornDots)); 
                    Console.Write("*");
                    Console.WriteLine(new String('.', firstHornDots));
                    firstHornDots--;
                    lastHornDots++;
                }
                else
                {
                    Console.WriteLine(new String('.',hornslength));
                }
			 middleDots-=2;
			}
            Console.Write(new String('.',width/2));
            Console.Write("*");
            Console.WriteLine(new String('.', width / 2));

            int leftRigthDots = X - 2;
            middleDots = 1;
            for (int i = 0; i < X-1; i++)
            {
                Console.Write(new String('.', hornslength));
                Console.Write(new String('.',leftRigthDots));
                Console.Write("*");
                Console.Write(new String('.', middleDots));
                Console.Write("*");
                Console.Write(new String('.', leftRigthDots));
                Console.WriteLine(new String('.', hornslength));
                middleDots += 2;
                leftRigthDots--;
            } 
            middleDots -= 4;
            for (int i = 1; i < X - 1; i++)
            {
                Console.Write(new String('.', hornslength));
                Console.Write(new String('.', i));
                Console.Write("*");
                Console.Write(new String('.', middleDots));
                Console.Write("*");
                Console.Write(new String('.', i));
                Console.WriteLine(new String('.', hornslength));
                middleDots -= 2;
            }
            Console.Write(new String('.', width / 2));
            Console.Write("*");
            Console.WriteLine(new String('.', width / 2));
          
        }
    }
}
