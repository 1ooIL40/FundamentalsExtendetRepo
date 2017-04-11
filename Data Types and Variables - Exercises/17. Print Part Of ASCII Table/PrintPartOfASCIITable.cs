
namespace _17.Print_Part_Of_ASCII_Table
{
    using System;

    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            for (int chars = firstInput; chars <= secondInput; chars++)
            {
                Console.Write($"{(char)chars} ");
            }
        }
    }
}
