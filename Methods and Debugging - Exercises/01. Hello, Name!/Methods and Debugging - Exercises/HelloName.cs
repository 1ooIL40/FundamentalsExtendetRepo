
namespace Methods_and_Debugging___Exercises
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var message = NamePrint(name);
            Console.WriteLine(message);
        }

        static string NamePrint(string name)
        {
            var result = $"Hello, {name}!";
            return result;
        }
    }
}
