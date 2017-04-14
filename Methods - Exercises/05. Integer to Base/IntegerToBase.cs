namespace _05.Integer_to_Base
{
    using System;

    public class IntegerToBase
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var result = IntToBase(number, toBase);
            Console.WriteLine(result);
        }

        static string IntToBase(int number, int toBase)
        {
            var output = string.Empty;

            while (number > 0)
            {
                var remainder = number % toBase;
                output = remainder + output;
                number /=  toBase;
            }

            return output;

        }
    }
}
