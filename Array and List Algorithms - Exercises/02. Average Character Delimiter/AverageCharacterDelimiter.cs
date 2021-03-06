﻿namespace _02.Average_Character_Delimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            //var text = "a b ab abc abc";

            var inputCharArray = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var charArray = string.Join(string.Empty, inputCharArray).ToCharArray();

            var len = charArray.Length;
            var sum = 0;

            foreach (var letter in charArray)
            {
                sum += letter;   
            }

            var charToAdd = (char)(sum / len);

            var delimiter = char.ToUpper(charToAdd);

            Console.WriteLine(string.Join($"{delimiter}",inputCharArray));

        }
    }
}
