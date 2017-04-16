
namespace _08.Multiply_Evens_by_Odds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var answer = GetMultipleOfEvenAndOdds(Math.Abs(number));
            Console.WriteLine(answer);
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {
            var sumEvens = GetSumOfEvenDigits(num);
            var sumOdd = GetSumOfOddDigits(num);

            var multiplaySums = sumEvens * sumOdd;

            return multiplaySums;
        }

         static int GetSumOfOddDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            
            while(num > 0)
            {
                int lastDigit = num % 10;
                if(lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }

            return sum;
        }
    }
}
