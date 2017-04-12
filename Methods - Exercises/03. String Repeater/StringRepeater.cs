
namespace _03.String_Repeater
{
    using System;

    public class StringRepeater
    {
        public static void Main()
        {
            var repeat = Console.ReadLine();
            var repeatNumber = int.Parse(Console.ReadLine());

            RepeateString(repeat, repeatNumber);
        }

        static void RepeateString(string repeat, int repeatNumber)
        {
            for (int i = 0; i < repeatNumber; i++)
            {
                Console.Write(repeat);
            }
            Console.WriteLine();
        }
    }
}
