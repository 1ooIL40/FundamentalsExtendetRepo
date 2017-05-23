namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var reginonAndShellSize = Console.ReadLine();
            var result = new Dictionary<string, List<int>>();

            while (reginonAndShellSize != "Aggregate")
            {
                var tokens = reginonAndShellSize.Split();
                var regionName = tokens[0];
                var shellSize = int.Parse(tokens[1]);

                if (!result.ContainsKey(regionName))
                {
                    result[regionName] = new List<int>();
                }
                if (!result[regionName].Contains(shellSize))
                {
                    result[regionName].Add(shellSize);
                }

                reginonAndShellSize = Console.ReadLine();
            }

            foreach (var regin in result)
            {
                var nameOfRegion = regin.Key;
                var sizeOfShell = regin.Value;


                Console.Write($"{nameOfRegion} -> ");
                
                var sum = 0;
                for (int i = 0; i < sizeOfShell.Count; i++)
                {
                    sum += sizeOfShell[i];
                }

                var giantShellSize = sum - (int)sizeOfShell.Average();
                
                Console.WriteLine($"{ string.Join(", ",sizeOfShell)} ({giantShellSize})" );
            }

        }
    }
}
