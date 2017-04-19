
namespace _03.Count_of_Given_Element_in_Array
{
    using System;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            var arrayOfIntegers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var number = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
