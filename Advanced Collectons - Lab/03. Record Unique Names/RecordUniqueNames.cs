namespace _03.Record_Unique_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
