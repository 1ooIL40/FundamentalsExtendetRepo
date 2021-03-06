﻿namespace _01.Letter_Repetition
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LetterRepetition
    {
        public static void Main()
        {
            var randomInputString = Console.ReadLine();

            var stringToCharArray = randomInputString.ToCharArray();

            var result = new Dictionary<char, int>();

            foreach (var element in randomInputString)
            {

                if (!result.ContainsKey(element))
                {
                    result[element] = 0;
                }
                result[element]++;
            }

            foreach (var kvp in result)
            {
                var key = kvp.Key;
                var value = kvp.Value;

                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
