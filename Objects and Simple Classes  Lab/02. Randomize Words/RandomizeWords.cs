namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var random = new Random();

            var rnd = random.Next(0, words.Count);

            for (int i = 0; i < words.Count; i++)
            {
                var word = words[i];

                if(i != rnd)
                {
                    var tempWord = words[rnd];
                    words[rnd] = word;
                    words[i] = tempWord;

                }
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
