
namespace _02.Multiply_an_Array_of_Doubles
{
    using System;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var arrayToMultiply = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var numberTpMultyply = double.Parse(Console.ReadLine());
            var result = 0.0;

            for (int i = 0; i < arrayToMultiply.Length; i++)
            {
                result = arrayToMultiply[i] * numberTpMultyply;
                Console.Write($"{result} ");
            }
        }
    }
}
