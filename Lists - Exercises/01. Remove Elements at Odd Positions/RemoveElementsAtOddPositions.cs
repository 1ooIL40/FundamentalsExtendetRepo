namespace _01.Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            //var text = "First Soft ccc Uni fifth";
            var input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
