﻿using System;

namespace MissCat
{
    class MissCat
    {
        static void Main()
        {
            int judge = int.Parse(Console.ReadLine());
            int[] cats = new int[11];
            for (int i = 0; i < judge; i++)
            {
                int mark = int.Parse(Console.ReadLine());
                mark++;
            }
            int max = 0;
            int result = 0;
            for (int i = 0; i < cats.Length; i++)
            {
                int currentValue = cats[i];
                if (max<currentValue)
                {
                    currentValue = max;
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
