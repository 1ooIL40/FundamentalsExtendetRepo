namespace Demo
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            //var sum = CalcSum(3, 4, 5);
            //Console.WriteLine(sum);

            var num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfOddEvenDigits(num);
            Console.WriteLine(result);
        }

        static long GetMultipleOfOddEvenDigits(int num)
        {
            var oddSum = SumOddDigits(num);
            var evenSum = SumEvenDigits(num);
            return oddSum * evenSum;
        }

        static long SumEvenDigits(int num)
        {
            long sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                num /= 10;
            }
            return sum;
        }

        static long SumOddDigits(int num)
        {
            long sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                num /= 10;
            }
            return sum;
        }

        static int CalcSum(int a, int b, int c)
        {
            var partialSum = Sum(a, b);
            var totalSum = Sum(partialSum, c);
            return totalSum;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
