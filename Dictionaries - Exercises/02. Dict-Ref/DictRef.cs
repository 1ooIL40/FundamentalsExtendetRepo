namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();
            var inputList = new List<string>();

            while (input != "end")
            {
                inputList = input
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var firstElement = inputList[0];
                var lastElement = inputList[inputList.Count - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                

                input = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                var key = kvp.Key;
                var value = kvp.Value;

                Console.WriteLine($"{key} === {value}");
            }
        }
    }
}
