namespace _02.Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("../../text.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("../../output.txt", ($"{i + 1}. " + text[i] + Environment.NewLine));
            }
        }
    }
}
