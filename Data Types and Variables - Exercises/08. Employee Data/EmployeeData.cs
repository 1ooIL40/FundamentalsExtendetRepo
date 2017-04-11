
namespace _08.Employee_Data
{
    using System;

    public class EmployeeData
    {
        public static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            short age = 27;
            string gender = "f";
            long iD = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {iD}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");

        }
    }
}
