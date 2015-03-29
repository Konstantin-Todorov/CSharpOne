using System;
class Lines
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int n = int.Parse(Console.ReadLine());

            int digit = 0;

            for (int j = 7; j >= 0; j--)
            {
                digit = n % 2;
                matrix[i, j] = digit;
                n = n / 2;
            }
        }

        int line = 0;
        int bestLine = 0;
        int bestLineCount = 1;

        for (int row = 0; row < 8; row++)
        {
            line = 0;
            for (int col = 0; col < 8; col++)
            {
                if (matrix[row, col] == 1)
                {
                    line++;

                    if (bestLine == line)
                    {
                        bestLineCount++;
                    }

                    if (bestLine < line)
                    {
                        bestLine = line;
                        bestLineCount = 1;
                    }
                }
                else
                {
                    line = 0;
                }
            }
        }

        for (int col = 0; col < 8; col++)
        {
            line = 0;
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    line++;

                    if (bestLine == line)
                    {
                        bestLineCount++;
                    }

                    if (bestLine < line)
                    {
                        bestLine = line;
                        bestLineCount = 1;
                    }
                }
                else
                {
                    line = 0;
                }
            }
        }

        if (bestLine == 1)
        {
            bestLineCount = bestLineCount / 2;
        }
        Console.WriteLine(bestLine);
        Console.WriteLine(bestLineCount);
    }
}
