using System;

class BitBall

{
    static void Main()
    {
        byte[] topTeam = new byte[8];
        byte[] bottomTeam = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            topTeam[i] = byte.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 8; i++)
        {
            bottomTeam[i] = byte.Parse(Console.ReadLine());
        }

        //byte[] topTeam = { 16, 74, 40, 0, 86, 0, 16, 0 };
        //byte[] bottomTeam = { 0, 0, 129, 73, 6, 4, 72, 16 };

        int topTeamGoals = 0;
        int bottomTeamGoals = 0;
        bool bottomPlayer = false;
        bool topPlayer = false;
        bool bottomTeamScored = false;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (((topTeam[row] >> col & 1) == 1) && ((bottomTeam[row] >> col & 1) == 1))
                {
                    int mask = ~(1 << col);
                    topTeam[row] &= (byte)mask;
                    mask = ~(1 << col);
                    bottomTeam[row] &= (byte)mask;
                }
            }
        }

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if ((bottomTeam[row] >> col & 1) == 1)
                {
                    bottomPlayer = true;
                }
                if ((topTeam[row] >> col & 1) == 1)
                {
                    topPlayer = true;
                    bottomPlayer = false;
                }

                if (bottomPlayer && !topPlayer && !bottomTeamScored)
                {
                    bottomTeamGoals++;
                    bottomPlayer = false;
                    bottomTeamScored = true;
                }
            }

            if (topPlayer && !bottomPlayer)
            {
                topTeamGoals++;
            }
            topPlayer = false;
            bottomPlayer = false;
            bottomTeamScored = false;
        }

        Console.WriteLine("{0}:{1}", topTeamGoals, bottomTeamGoals);
    }
}