
namespace _02.Max_Method
{
    using System;

    public class MinMethod
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var max = GetMin(firstNumber, secondNumber);
            var result = GetMin(max, thirdNumber);
            Console.WriteLine(result);
        }

        static int GetMin(int first, int second)
        {
            if (first > second)
            {
                return second;
            }
            return first;
        }
    }
}
