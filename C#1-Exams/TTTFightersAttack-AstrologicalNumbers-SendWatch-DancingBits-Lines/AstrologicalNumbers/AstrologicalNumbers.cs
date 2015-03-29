using System;

class AstrologicalNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        while (true)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!((input[i] == '.' || input[i] == '-')))
                {
                    sum += int.Parse(input[i].ToString());
                }
            }
            if (sum < 10)
            {
                break;
            }
            input = sum.ToString();
            sum = 0;
        }
        Console.WriteLine(sum);
    }
}


