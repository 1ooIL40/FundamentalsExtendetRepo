
namespace _04.Rotate_Array_of_Strings
{
    using System;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var arrayOfStrings = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var lastWord = arrayOfStrings.Length;

            Console.Write(arrayOfStrings[lastWord -1]);
            for (int i = 0; i < lastWord - 1; i++)
            {
                Console.Write($" {arrayOfStrings[i]}");
            }
            Console.WriteLine();
        }
    }
}
