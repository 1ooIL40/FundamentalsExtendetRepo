﻿namespace _01.Min__Max__Sum__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                numbers[i] = num;
            }

            var sum = numbers.Sum();
            var min = numbers.Min();
            var max = numbers.Max();
            var avg = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {avg}");

        }
    }
}
