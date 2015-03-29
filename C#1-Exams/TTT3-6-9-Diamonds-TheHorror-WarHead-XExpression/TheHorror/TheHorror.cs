//Chete tekst printira kolko chetni chils ima v nego i tqhnata suma

using System;
class TheHorror
{
    static void Main()
    {
        string text = Console.ReadLine();
        int sum = 0;
        int evenCounter = 0;
        int counter = 0;
        foreach (char symbol in text)
        {
            if (counter % 2 == 0)
            {
                if (Char.IsDigit(symbol))
                {
                    evenCounter++;
                    sum += symbol - '0';
                }
            } counter++;
        } Console.WriteLine("{0} {1}", evenCounter, sum);
    }
}
