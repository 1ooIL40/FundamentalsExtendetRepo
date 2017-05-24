namespace _03.Forum_Topics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        public static void Main()
        {
            var inputTopicLine = Console.ReadLine();
            var forumTopics = new Dictionary<string, List<string>>();

            while (inputTopicLine != "filter")
            {
                var tokens = inputTopicLine.Split((" ->,").ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                var topic = tokens[0];

                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics[topic] = new List<string>();
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    if (!forumTopics[topic].Contains(tokens[i]))
                    {
                        forumTopics[topic].Add(tokens[i]);
                    }
                }
                inputTopicLine = Console.ReadLine();
            }

            inputTopicLine = Console.ReadLine();

            var tagSequence = inputTopicLine
                .Split((" ,").ToCharArray(),
                  StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            foreach (var topics in forumTopics)
            {
                var topic = topics.Key;
                var tagList = topics.Value;

                var isTrue = true;

                for (int i = 0; i < tagSequence.Count; i++)
                {

                    if (!tagList.Contains(tagSequence[i]))
                    {
                        isTrue = false;
                        break;
                    }
                    
                }

                if (isTrue)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #",tagList)}");
                }

            }
        }
    }
}
