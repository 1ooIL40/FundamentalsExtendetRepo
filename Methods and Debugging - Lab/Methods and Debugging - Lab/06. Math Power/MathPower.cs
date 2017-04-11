
namespace _06.Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var answer = PowerOneNumber(number, power);
            Console.WriteLine(answer);
        }

        static double PowerOneNumber(double num, double degree)
        {
            double result = 1;

            for (int i = 1; i <= degree; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
