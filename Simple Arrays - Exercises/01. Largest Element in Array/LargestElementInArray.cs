
namespace _01.Largest_Element_in_Array
{
    using System;
    using System.Linq;

    public class LargestElementInArray
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var biggestElement = int.MinValue;
            var arrayOfIntegers = new int[number];

            for (int i = 0; i < number; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
                if (biggestElement < arrayOfIntegers[i])
                {
                    biggestElement = arrayOfIntegers[i];
                }
            }
            Console.WriteLine(biggestElement);
        }
    }
}
