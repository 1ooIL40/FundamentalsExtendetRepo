namespace _04.Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            string[] inputOne = File.ReadAllLines("../../input1.txt");
            string[] inputTwo = File.ReadAllLines("../../input2.txt");

            List<int> numbers = new List<int>();
            foreach (var num in inputOne)
            {
                numbers.Add(int.Parse(num));
            }
            foreach (var num in inputTwo)
            {
                numbers.Add(int.Parse(num));
            }
            numbers.Sort();

            File.AppendAllText("../../output.txt", string.Join(Environment.NewLine, numbers));
        }
    }
}
