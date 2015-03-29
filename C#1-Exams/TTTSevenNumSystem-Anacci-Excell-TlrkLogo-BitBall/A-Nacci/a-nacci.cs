using System;

namespace A_Nacci
{
    class anacci
    {
        static void Main()
        {
            int shift = 64;//zada vzemem nomera na koit se namirat

            string firstLetter = Console.ReadLine();
            int first = firstLetter[0] - shift; //izvajdame zada vzemem samoto mqsto 

            string secondLetter = Console.ReadLine();
            int second = secondLetter[0] - shift;

            int rows = int.Parse(Console.ReadLine());
             Console.WriteLine((char)(first + shift));
            if (rows > 1)
            {
                int result = first + second;
                if (result > 26)
                {
                    result = result % 26;
                }
                string next = ((char)(second + shift)).ToString()
                   + ((char)(result + shift)).ToString();
                Console.WriteLine(next);
                first = second;
                second = result;
                for (int i = 3; i <= rows; i++)
                {
                    result = first + second;
                    if (result > 26)
                    {
                        result = result % 26;
                    }
                    first = second;
                    second = result;
                    result = first + second;
                    if (result > 26)
                    {
                        result = result % 26;
                    }
                    first = second;
                    second = result;
                    Console.Write((char)(first + shift));
                    Console.Write(new String(' ', i - 2));
                    Console.WriteLine((char)(second + shift));
                }
            }
        }
    }
}
