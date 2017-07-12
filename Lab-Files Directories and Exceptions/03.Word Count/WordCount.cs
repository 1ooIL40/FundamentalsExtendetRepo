namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("../../words.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> keyWords = new Dictionary<string, int>();
            keyWords["quick"] = 0;
            keyWords["is"] = 0;
            keyWords["fault"] = 0;
            foreach (var word in words)
            {
                if (keyWords.ContainsKey(word))
                {
                    keyWords[word]++;
                }
            }
            keyWords = keyWords.OrderByDescending(w => w.Value)
                .ToDictionary(w => w.Key, v => v.Value);

            foreach (var word in keyWords)
            {
                File.AppendAllText("../../text.txt", $"{word.Key} - {word.Value}" + Environment.NewLine);
            }
        }
    }
}
