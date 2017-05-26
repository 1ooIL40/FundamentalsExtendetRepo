namespace _02.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
