namespace _03.Reverse_Array_In_place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

           
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
