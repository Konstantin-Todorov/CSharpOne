using System;

namespace EmployeeData
{
    class EmplyeeData
    {
        static void Main()
        {
            Console.Write("Employee's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Employee's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Employee's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Employee's gender: ");
            char gender = Console.ReadLine().Trim()[0];
            Console.Write("Employee's number: ");
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
            Console.Write("Personal ID: ");
            long personalID = long.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(@"
Employee:           {0} {1}
Age:                {2}
Gender:             {3}
Employee Number:    {4}
Personal ID:        {5}
", firstName, lastName, age, 
 (gender.ToString().ToUpper() == "M") ? "Male" : "Female", uniqueEmployeeNumber, personalID);
        }
    }
}

      
