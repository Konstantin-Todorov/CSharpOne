using System;

namespace SevenLandNumbers
{
    class SevenLandNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int powerConter = 0;
            int decimalNumber = 0;

            while (inputNumber != 0)
            {
                int lastNumber = inputNumber % 10;
                decimalNumber += lastNumber * Math.Pow(7, powerCounter);
                powerCounter++;
                inputNumber /= 10;
            }
            decimalNumber++;
            inputNumber /= 10;
            while (decimalNumber != 0)
            {
                int lastNumber = decimalNumber % 7;
                result += lastNumber;
                decimalNumber /= 7;
            }
            Console.WriteLine(result);
            
            //int k = int.Parse(Console.ReadLine());

            //if (k == 666)
            //{
            //    k = 1000;
            //}
            //else if ((k % 100) == 66)
            //{
            //    k += 34;
            //}
            //else if (k % 10 != 6)
            //{
            //    k++;
            //}
            //else if (k % 10 == 6)
            //{
            //    k += 4;
            //}
            //Console.WriteLine(k);



        }
    }
}
