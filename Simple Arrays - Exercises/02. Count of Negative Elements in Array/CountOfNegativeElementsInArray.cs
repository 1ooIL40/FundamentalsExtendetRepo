
namespace _02.Count_of_Negative_Elements_in_Array
{
    using System;
    using System.Linq;

    public class CountOfNegativeElementsInArray
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var arrayOfIntegers = new int[n];
            var count = 0;

            for (int i = 0; i < n; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());

                if(arrayOfIntegers[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
