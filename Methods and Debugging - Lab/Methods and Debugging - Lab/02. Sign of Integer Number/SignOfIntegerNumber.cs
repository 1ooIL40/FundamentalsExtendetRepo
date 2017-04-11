
namespace _02.Sign_of_Integer_Number
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            
        }
    }
}
