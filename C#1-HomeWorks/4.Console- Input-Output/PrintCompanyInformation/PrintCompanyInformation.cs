//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company name : ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company addres : ");
            string companyAddres = Console.ReadLine();
            Console.Write("Enter Company phone number : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter Company fax : ");
            string faxNumber = Console.ReadLine();
            Console.Write("Enter Company website : ");
            string webSite = Console.ReadLine();
            Console.Write("Enter Manager name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Manager name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Manager age : ");
            string age = Console.ReadLine();
            Console.Write("Enter Manager phone : ");
            string phone = Console.ReadLine();

            if (faxNumber.Length < 5)
            {
                faxNumber = "( No fax. )";
            }
            if (phoneNumber.Length > 12)
            {
                phoneNumber = "( No phone number.)";
            }

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Company name : " + companyName);
            Console.WriteLine("Company addres : " + companyAddres);
            Console.WriteLine("Company phone number : " + phoneNumber);
            Console.WriteLine("Company fax : " + faxNumber);
            Console.WriteLine("Company website : " + webSite);
            Console.WriteLine("Manager name : " + firstName + " " + lastName);
            Console.WriteLine("Manager age : " + age);
            Console.WriteLine("Manager phone : " + phone);
            Console.WriteLine("---------------------------------------------");


        }
    }
}
