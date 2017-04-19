
namespace _06.Odd_Numbers_at_Odd_Positions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (i % 2 == 1 && Math.Abs(arrayOfNumbers[i]) % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {arrayOfNumbers[i]}");
                } 
            }
        }
    }
}
