
namespace _01.Sum_Array_Elements
{
    using System;
    using System.Linq;

    public class SumArrayElements
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var arrayOfNumbers = new int[number];
            var sum = 0;

            for (int i = 0; i < number; i++)
            {
                var numberInArray = int.Parse(Console.ReadLine());
                arrayOfNumbers[i] = numberInArray;
                sum += arrayOfNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
