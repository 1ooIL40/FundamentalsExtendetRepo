
namespace _04.Nth_Digit
{
    using System;

    public class NthDigit
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var nthDigit = int.Parse(Console.ReadLine());

            var theDigit = FindNthDigit(number, nthDigit);

            Console.WriteLine(theDigit);
        }

        static long FindNthDigit(long number, int nthDigit)
        {
            var index = 1;

            while (number > 0)
            {
                if (index == nthDigit)
                {
                    number = number % 10;
                    break;
                }
                else
                {
                    number = number / 10;
                }
                index++;
            }
            return number;
        }
    }
}
