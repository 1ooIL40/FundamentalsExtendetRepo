
namespace _05.Count_of_Odd_Numbers_in_Array
{
    using System;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var arrayOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var count = 0;

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {

                if(arrayOfIntegers[i] != 0 && arrayOfIntegers[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
