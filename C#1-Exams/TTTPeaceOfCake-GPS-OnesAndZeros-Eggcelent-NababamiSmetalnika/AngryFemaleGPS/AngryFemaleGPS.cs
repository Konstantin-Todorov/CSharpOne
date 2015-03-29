using System;

class AngryFemaleGPS
{
    static void Main()
    {
        string N = Console.ReadLine();
        long oddDigits = 0;
        long evenDigits = 0;
        for (int i = 0; i < N.Length; i++)
        {
            if (char.IsDigit(N[i]))
            {
                if (long.Parse(N[i].ToString())%2==1)
                {
                    oddDigits += long.Parse(N[i].ToString());
                }
                else 
                {
                    evenDigits += long.Parse(N[i].ToString());
                }
            }
        }
        if (evenDigits>oddDigits)
        {
            Console.WriteLine("right {0}",evenDigits);
        }
        else if (oddDigits>evenDigits)
        {
            Console.WriteLine("left {0}",oddDigits);
        }
        else if (evenDigits==oddDigits)
        {
            Console.WriteLine("straight "+evenDigits);
        }
    }
}

