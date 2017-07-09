namespace _03.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LINQuistics
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var linqMethods = new Dictionary<string, HashSet<string>>();

            while (inputLine != "exit")
            {
                var inputParams = inputLine
                    .Split(" .()".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var isNumber = false;
                var number = 0;

                //find if the "inputParams" are digits ONLY
                if (inputParams.Count == 1)
                {
                    if (int.TryParse(inputParams[0], out number))
                    {
                        isNumber = true;
                    }

                    if (linqMethods.ContainsKey(inputParams[0]))
                    {
                        var givenNameOnly = linqMethods[inputParams[0]]
                            .ToList()
                            .OrderByDescending(x => x.Length)
                            .ToList();

                        //Method that order by unique sybols in two methods with equal lenght
                        givenNameOnly = OrderByUniqueSymbols(givenNameOnly);

                        for (var i = 0; i <= givenNameOnly.Count - 1; i++)
                        {

                            Console.WriteLine($"* {givenNameOnly[i]}");
                        }

                    }

                }

                //Add only if is not a number
                if (!isNumber)
                {
                    linqMethods = AddParamsAndMethods(linqMethods, inputParams);
                }
                else
                {
                    //Take bigest collections orderBy length and  print first 3 methods 

                    var biggestCollection = linqMethods.Values
                        .First(bi => bi.Count == linqMethods.Values.Max(l => l.Count()))
                        .OrderBy(bi => bi.Length)
                        .Take(number)
                        .ToList();

                        foreach (var collection in biggestCollection)
                        {
                            Console.WriteLine($"* {collection}");
                        }
                }
                
                inputLine = Console.ReadLine();
            }

            //Take last input from the user
            var printCommand = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var methodSearch = printCommand[0];
            var command = printCommand[1];

            //make new dictioary wich contains the method user give us and sort it
            var matchingInCollections = linqMethods
                .ToDictionary(x => x.Key, y => y.Value)
                .Where(c => c.Value.Contains(methodSearch))
                .OrderByDescending(y => y.Value.Count)
                .ThenByDescending(y => y.Value.Min(m => m.Length))
                .ToDictionary(x => x.Key, y => y.Value);

            //go tru the dictionary and complete the command that user give us
            foreach (var kvp in matchingInCollections)
            {
                Console.WriteLine(kvp.Key);
                if (command == "all")
                {
                    var orderedMethods = kvp.Value
                        .OrderByDescending(y => y.Length);

                    foreach (var meth in orderedMethods)
                    {

                        Console.WriteLine($"* {meth}");
                    }
                }
            }


        }
        #region Order by unique sybols
        static List<string> OrderByUniqueSymbols(List<string> givenNameOnly)
        {
            var result = new List<string>();

            for (int i = 0; i <= givenNameOnly.Count - 1; i++)
            {
                
                var first = givenNameOnly[i].ToCharArray();

                // fixed out of range exeption
                if (i < givenNameOnly.Count - 1)
                {
                    var second = givenNameOnly[i + 1].ToCharArray();

                    //check the length if its equal chek for unique sybols and sort
                    if (first.Length == second.Length)
                    {
                        if (first.Distinct().Count() >= second.Distinct().Count())
                        {
                            result.Add(givenNameOnly[i]);
                        }
                        else
                        {
                            result.Add(givenNameOnly[i + 1]);
                        }
                    }
                }

                // if the lenght is not equal add in that order
                if (!result.Contains(givenNameOnly[i]))
                {
                    result.Add(givenNameOnly[i]);
                }
            }
            
            return result;
        }
        #endregion

        #region Dictionary with Methods
        static Dictionary<string, HashSet<string>> AddParamsAndMethods(Dictionary<string, HashSet<string>> linqMethods, List<string> inputParams)
        {
            //add collection
            if (!linqMethods.ContainsKey(inputParams[0]))
            {
                linqMethods[inputParams[0]] = new HashSet<string>();
            }

            //add methods to the collections
            for (int i = 1; i < inputParams.Count; i++)
            {
                var methodsToAdd = inputParams[i];

                if (!linqMethods[inputParams[0]].Contains(methodsToAdd))
                {
                    linqMethods[inputParams[0]].Add(methodsToAdd);
                }
                else
                {
                    linqMethods[inputParams[0]].Remove(methodsToAdd);
                }
            }

            return linqMethods;
        }
        #endregion
    }
}
