
namespace _02.Max_Method
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var max = GetMax(firstNumber, secondNumber);
            var result = GetMax(max, thirdNumber);
            Console.WriteLine(result);
        }

        static int GetMax(int firs, int second)
        {
            if (firs > second)
            {
                return firs;
            }
            return second;
        }
    }
}
