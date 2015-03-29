using System;

namespace BankAcc
{
    class bankAcc
    {
        static void Main()
        {
            Console.Title = "Bank Account Data";
            Console.WriteLine("Input bank account data:");
            Console.WriteLine();
            Console.Write("Enter first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter middle name: ");
            string middle = Console.ReadLine();
            Console.Write("Enter last name: ");
            string last = Console.ReadLine();
            Console.Write("Enter your available amount of money (balance): ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter bank name: ");
            string bankName = Console.ReadLine();
            Console.Write("Enter IBAN: ");
            string iban = Console.ReadLine();
            Console.Write("Enter first credit card number (12 numbers): ");
            ulong creditCardNum1 = ulong.Parse(Console.ReadLine());
            while (creditCardNum1 < 0 || creditCardNum1 > 999999999999)
            {
                Console.Write("Enter third credit card number (12 numbers): ");
                creditCardNum1 = ulong.Parse(Console.ReadLine());
            }
            Console.Write("Enter second credit card number (12 numbers): ");
            ulong creditCardNum2 = ulong.Parse(Console.ReadLine());
            while (creditCardNum2 < 0 || creditCardNum2 > 999999999999)
            {
                Console.Write("Enter third credit card number (12 numbers): ");
                creditCardNum2 = ulong.Parse(Console.ReadLine());
            }
            Console.Write("Enter third credit card number (12 numbers): ");
            ulong creditCardNum3 = ulong.Parse(Console.ReadLine());
            while (creditCardNum3 < 0 || creditCardNum3 > 999999999999)
            {
                Console.Write("Enter third credit card number (12 numbers): ");
                creditCardNum3 = ulong.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Bank Account Data is:");
            Console.WriteLine();
            Console.WriteLine("First name: " + first);
            Console.WriteLine("Middle name: " + middle);
            Console.WriteLine("Last name: " + last);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Bank Name: " + bankName.ToUpper());
            Console.WriteLine("IBAN: " + iban.ToUpper());
            Console.WriteLine("First credit card number: " + creditCardNum1);
            Console.WriteLine("Second credit card number: " + creditCardNum1);
            Console.WriteLine("Third credit card number: " + creditCardNum1);
        }
    }
}
