using System;
namespace DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main()
        {
            int rounds = int.Parse(Console.ReadLine());

            int leftNumbers = 0;
            int rightNumbers = 0;

            for (int i=0;i<rounds;i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(currentNumber<0)
                {
                    currentNumber *= -1;
                }
                int numberOfDdigits = 0;
                int num = currentNumber;
                while (num != 0)
                {
                    num = num / 10;
                    numberOfDdigits++;
                }
                for (int right = 0; right < numberOfDdigits/2; right++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    rightNumbers = rightNumbers + currentDigit;
                }
                if (numberOfDdigits % 2 ==1)
                {
                    int middleDigit = currentNumber % 10;
                    leftNumbers = leftNumbers + middleDigit;
                    rightNumbers = rightNumbers + middleDigit;
                    currentNumber = currentNumber / 10;
                }
                for (int left = 0; left < numberOfDdigits/2; left++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    leftNumbers = leftNumbers + currentDigit;
                }
            }
            int difference = leftNumbers - rightNumbers;
            if (difference > 0)
            {
                Console.WriteLine("M {0}", difference);
            }
            else if (difference < 0)
            {
                Console.WriteLine("V {0}", difference*-1);
            }
            else
            {
                Console.WriteLine("No {0}",rightNumbers+leftNumbers);
            }
        }
    }
}
