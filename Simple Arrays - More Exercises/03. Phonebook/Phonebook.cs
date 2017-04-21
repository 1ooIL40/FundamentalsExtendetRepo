
namespace _03.Phonebook
{
    using System;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var arrayOfNames = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            PhoneBook(arrayOfNumbers, arrayOfNames);

            
        }

        static void PhoneBook(string[] arrayOfNumbers, string[] arrayOfNames)
        {
            var len = arrayOfNumbers.Length;
            var result = string.Empty;
            var names = Console.ReadLine();

            while (names != "done")
            {
                for (int i = 0; i < len; i++)
                {
                    if (names == arrayOfNames[i])
                    {
                        Console.WriteLine($"{arrayOfNames[i]} -> {arrayOfNumbers[i]}");
                    }
                }
                names = Console.ReadLine();
            }

        }
    }
}
