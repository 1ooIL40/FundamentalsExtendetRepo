namespace _01.Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("../../text.txt");

            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("../../output.txt",text[i] + Environment.NewLine);
            }
        }
    }
}
