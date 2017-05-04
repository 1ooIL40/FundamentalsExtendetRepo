namespace _06.Insertion_Sort_Using_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            var result = numbers.Take(n);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
