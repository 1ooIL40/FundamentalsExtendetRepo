namespace _04.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var firstUpperPart = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var secondUpperPart = numbers
                .Reverse()
                .Take(k)
                .ToArray();
            var upperNumbers = firstUpperPart
                .Concat(secondUpperPart)
                .ToArray();

            var lowerNumbers = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var resultNumbers = new int[upperNumbers.Length];


            for (int i = 0; i < upperNumbers.Length; i++)
            {
                resultNumbers[i] = upperNumbers[i] + lowerNumbers[i];
            }

            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
