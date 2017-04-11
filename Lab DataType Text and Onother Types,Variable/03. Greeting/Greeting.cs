
namespace _03.Greeting
{
    using System;

    public class Greeting
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
