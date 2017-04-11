
namespace _14.Integer_to_Hex_and_Binary
{
    using System;

    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            decimal numbers = decimal.Parse(Console.ReadLine());

            int number = (int)numbers;

            string hexNumber = Convert.ToString(number, 16).ToUpper();
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine(hexNumber);
            Console.WriteLine(binaryNumber);
        }
    }
}
