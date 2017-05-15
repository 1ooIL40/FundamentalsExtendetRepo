namespace _04.Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Extremums
    {
        public static void Main()
        {
            //var input = "255 590 90018 12 10";
            //var com = "Max";

            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            var sum = 0;
            var rotatedIntegers = new List<int>();

            


            switch (command)
            {
                case "Max":
                    rotatedIntegers = GetMaxIntegersOnAllPositions(numbers);
                    sum = GetSumOfIntegers(rotatedIntegers);
                    break;
                case "Min":
                    rotatedIntegers = GetMinIntegersOnAllPositions(numbers);
                    sum = GetSumOfIntegers(rotatedIntegers);
                    break;
            }

            Console.WriteLine(string.Join(", ", rotatedIntegers));
            Console.WriteLine(sum);
        }

        static List<int> GetMaxIntegersOnAllPositions(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                var minInteger = numbers[i].ToString();
                var rotatedNumbers = RotatadeNumbers(minInteger);

                if (numbers[i] < rotatedNumbers)
                {
                    numbers[i] = rotatedNumbers;
                    i--;
                }

            }
            return numbers;
        }

        static List<int> GetMinIntegersOnAllPositions(List<int> numbers)
        {

            for (int i = 0; i < numbers.Count; i++)
            {
                var minInteger = numbers[i].ToString();
                var rotatedNumbers = RotatadeNumbers(minInteger);

                if (numbers[i] > rotatedNumbers)
                {
                    numbers[i] = rotatedNumbers;
                    i--;
                }

            }
            return numbers;
        }

        static int RotatadeNumbers(string numbers)
        {
            var charArray = numbers.ToCharArray();
            var first = charArray[0];
            var newNumber = string.Empty;

            for (int i = 1; i < charArray.Length; i++)
            {
                newNumber += charArray[i];
            }
            newNumber += first;

            var result = int.Parse(newNumber);

            return result;
        }

        static int GetSumOfIntegers(List<int> numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
