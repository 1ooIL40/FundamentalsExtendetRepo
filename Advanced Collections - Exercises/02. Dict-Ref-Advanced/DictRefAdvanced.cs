namespace _02.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var dictRef = new Dictionary<string, List<int>>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(("-> ,").ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var name = tokens[0];
                var integerToAdd = 0;
                

                if(int.TryParse(tokens[1], out integerToAdd))
                {

                    if (!dictRef.ContainsKey(name))
                    {
                        dictRef[name] = new List<int>();
                    }

                    for (int i = 1; i < tokens.Count; i++)
                    {
                        dictRef[name].Add(int.Parse(tokens[i]));
                    }
                }
                else
                {
                    var secondName = tokens[1];

                    if (dictRef.ContainsKey(secondName))
                    {
                        dictRef[name] = dictRef[secondName];
                    }
                    
                }
                inputLine = Console.ReadLine();
            }

            foreach (var item in dictRef)
            {
                var key = item.Key;
                var value = item.Value;

                Console.WriteLine($"{key} === {string.Join(", ", value)}");
            }
        }
    }
}
