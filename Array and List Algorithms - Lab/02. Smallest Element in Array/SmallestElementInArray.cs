namespace _02.Smallest_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                  .Split(new char[] { ' ' },
                  StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            var smallestNumber = numbers.Min();

            Console.WriteLine(smallestNumber);
        }
    }
}
