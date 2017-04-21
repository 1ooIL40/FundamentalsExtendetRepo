
namespace _02.Array_Elements_Equal_to_Their_Index
{
    using System;
    using System.Linq;

    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            EqualElementsOfTheirIndex(arrayOfNumbers);
        }

        static void EqualElementsOfTheirIndex(int[] arrayOfNumbers)
        {

            var len = arrayOfNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (i == arrayOfNumbers[i])
                {
                    Console.Write($"{arrayOfNumbers[i]} "); 
                }
            }
            Console.WriteLine();
        }
    }
}
