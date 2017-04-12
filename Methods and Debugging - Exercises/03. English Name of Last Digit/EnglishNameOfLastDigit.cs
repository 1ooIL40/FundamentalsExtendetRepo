
namespace _03.English_Name_of_Last_Digit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var output = LastDigitInWords(number);
        }

        static object LastDigitInWords(int number)
        {
            var arreyOfWords = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        }
    }
}
