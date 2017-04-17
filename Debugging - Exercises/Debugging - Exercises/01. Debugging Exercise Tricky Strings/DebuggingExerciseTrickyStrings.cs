
namespace _01.Debugging_Exercise_Tricky_Strings
{
    using System;

    public class DebuggingExerciseTrickyStrings
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                result += currentString;
                if (i != numberOfStrings)
                {
                    result += delimiter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
