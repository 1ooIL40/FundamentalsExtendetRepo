namespace _06.Square_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var square = Math.Sqrt(numbers[i]);
                if (square == (int)square)
                {
                    result.Add(numbers[i]);
                }
            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
