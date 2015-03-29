//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InstalledUICulture;
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.Write("\nPlease choose a type : ");
            int number = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("\nThis is not correct choose!");
            }
       
            switch (number)
            {
                case 1:
                    Console.Write("\nPlease enter a int : ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result --> " + (num + 1));
                    break;
                case 2:
                    Console.Write("\nPlease enter a double : ");
                    double numDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result --> " + (numDouble + 1));
                    break;
                case 3:
                    Console.Write("\nPlease enter a string : ");
                    string strInput = Console.ReadLine();
                    Console.WriteLine("Result --> " + strInput + "*");
                    break;
                default:
                    Console.WriteLine("\nThis is not correct choose!");
                    break;
            }
        }
    }
}
