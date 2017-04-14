namespace _05.Integer_to_Base
{
    using System;

    public class IntegerToBase
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var result = IntToBase(number, toBase);
            Console.WriteLine(result);
        }

        static string IntToBase(long number, int toBase)
        {
            var output = string.Empty;
            var remainder = 0;

            remainder = (int)number % toBase;
            if (number > 0)
            {
                output += number = number / toBase;
            }
            output += remainder;

            return output;

        }
    }
}
