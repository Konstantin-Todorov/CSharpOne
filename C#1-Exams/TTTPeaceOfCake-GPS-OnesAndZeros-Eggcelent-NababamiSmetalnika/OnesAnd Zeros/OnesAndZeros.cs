using System;


class OnesAndZeros
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        string[] one = {".#.",
                        "##.",
                        ".#.",
                        ".#.",
                        "###"};
            
        string[] zero ={"###",
                        "#.#",
                        "#.#",
                        "#.#",
                        "###"};
        for (int row = 0; row < 5; row++)
        {
            for (int i = 15; i >= 0; i--)
            {
                int bit = num & (1 << i);
                if (bit>0)
                {
                    Console.Write(one[row]);
                }
                else
                {
                    Console.Write(zero[row]);
                }
                if (i!=0)
                    Console.Write('.');
            }
            Console.WriteLine();
        }

        //int num = int.Parse(Console.ReadLine());
        //string binary = Convert.ToString(num, 2).PadLeft(32,'0');
        //string oneRow0 = ".#.";
        //string oneRow1 = "##.";
        //string oneRow2 = ".#.";
        //string oneRow3 = ".#.";
        //string oneRow4 = "###";

        //string zeroRow0 = "###";
        //string zeroRow1 = "#.#";
        //string zeroRow2 = "#.#";
        //string zeroRow3 = "#.#";
        //string zeroRow4 = "###";
        //for (int i = 16; i < binary.Length; i++) 
        //{
        //    //0
        //    if (binary[i] == '1')
        //    {
        //        Console.Write(oneRow0);
        //    }
        //    else
        //    {
        //        Console.Write(zeroRow0);
        //    }
        //    if (i!=binary.Length-1)
            
        //        Console.Write('.');    
        //}
        //Console.WriteLine();
        //for (int i = 16; i < binary.Length; i++) 
        //{
        //    //1
        //    if (binary[i] == '1')
        //    {
        //        Console.Write(oneRow1);
        //    }
        //    else
        //    {
        //        Console.Write(zeroRow1);
        //    }
        //    if (i!=binary.Length-1)
            
        //        Console.Write('.');    
        //}
        //Console.WriteLine();
        //for (int i = 16; i < binary.Length; i++) 
        //{
        //    //2
        //    if (binary[i] == '1')
        //    {
        //        Console.Write(oneRow2);
        //    }
        //    else
        //    { 
        //        Console.Write(zeroRow2);
        //    }
        //    if (i!=binary.Length-1)
            
        //        Console.Write('.');    
        //}
        //Console.WriteLine();
        //for (int i = 16; i < binary.Length; i++) 
        //{
        //    //3
        //    if (binary[i] == '1')
        //    {
        //        Console.Write(oneRow3);
        //    }
        //    else
        //    {
        //        Console.Write(zeroRow3);
        //    }
        //    if (i!=binary.Length-1)
            
        //        Console.Write('.');    
        //}
        //Console.WriteLine();
        //for (int i = 16; i < binary.Length; i++) 
        //{
        //    //4
        //    if (binary[i] == '1')
        //    {
        //        Console.Write(oneRow4);
        //    }
        //    else
        //    {
        //        Console.Write(zeroRow4);
        //    }
        //    if (i!=binary.Length-1)
            
        //        Console.Write('.');    
        //}
        //Console.WriteLine();
        }
}
    


