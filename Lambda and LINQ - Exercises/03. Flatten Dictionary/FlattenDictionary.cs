namespace _03.Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var defaultDictionary = new Dictionary<string, Dictionary<string, string>>();
            var flattenDictionary = new Dictionary<string,string>();

            var flattenKey = string.Empty;

            while (inputLine != "end")
            {
                var tokens = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                var firstWord = tokens[0];
                var secondWord = tokens[1];

                if (firstWord != "flatten")
                {
                    var thirdWord = tokens[2];

                    if (!defaultDictionary.ContainsKey(firstWord))
                    {
                        defaultDictionary[firstWord] = new Dictionary<string, string>();
                    }
                    defaultDictionary[firstWord][secondWord] = thirdWord;
                }
                else
                {
                    defaultDictionary[secondWord] = defaultDictionary[secondWord]
                        .ToDictionary(x => x.Key + x.Value, x => "flattend");
                }

                inputLine = Console.ReadLine();
            }

            var result = defaultDictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);



            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Key}");
                var orderedInnerDictionary =
                    entry.Value
                    .Where(x=> x.Value != "flattend")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattendValues =
                    entry.Value
                    .Where(x => x.Value == "flattend")
                    .ToDictionary(x => x.Key, x => x.Value);

                int count = 1;

                foreach (var innerEntry in orderedInnerDictionary)
                {
                    Console.WriteLine($"{count}. {innerEntry.Key} - {innerEntry.Value}");
                    count++;
                }

                foreach (var flattenEntry in flattendValues)
                {
                    Console.WriteLine($"{count}. {flattenEntry.Key}");
                    count++;
                }
            }
        }
    }
}
