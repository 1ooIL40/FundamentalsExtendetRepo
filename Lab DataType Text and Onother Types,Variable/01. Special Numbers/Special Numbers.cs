
namespace specialNumbers
{
    using System;
    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                var sumofDigits = 0;
                var digits = num;
                while(digits > 0)
                {
                    sumofDigits += digits % 10;
                    digits = digits / 10;
                }
                var result = (sumofDigits == 5) || (sumofDigits == 7) || (sumofDigits == 11);
                Console.WriteLine($"{num} -> {result}");
            }
        }
    }
}
