
namespace _04.Variable_in_Hex_Format
{
    using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            var number = Console.ReadLine();

            int result = Convert.ToInt32(number, 16);
            Console.WriteLine(result);
        }
    }
}
