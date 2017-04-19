
namespace _04.Count_Occurrences_of_Larger_Numbers_in_Array
{
    using System;
    using System.Linq;

    public class CountOccurrencesOfLargerNumbersInArray
    {
        public static void Main()
        {
            var arrayOfRealNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var number = double.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < arrayOfRealNumbers.Length; i++)
            {
                if(arrayOfRealNumbers[i] > number)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
