namespace _07.Count_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var countArray = new int[1001];

            foreach (var number in numbers)
            {
                countArray[number]++;
            }

            for (int i = 0; i < countArray.Length; i++)
            {
                if (countArray[i] > 0)
                {
                    Console.WriteLine($"{i} -> {countArray[i]}");
                }
            }
        }
    }
}
