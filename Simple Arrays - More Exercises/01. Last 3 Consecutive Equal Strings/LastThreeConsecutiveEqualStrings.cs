
namespace _01.Last_3_Consecutive_Equal_Strings
{
    using System;
    using System.Linq;

    public class LastThreeConsecutiveEqualStrings
    {
        public static void Main()
        {
            //var text = "one one one one two hi hi my echo last last last pi";
            var words = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            LastThreeEqualStrings(words);
        }

        static void LastThreeEqualStrings(string[] words)
        {
            var len = words.Length;
            var count = 1;

            for (int i = len - 1; i >= 0; i--)
            {
                var word = words[i];
                var compare = words[i-1];
                

                if (word == compare)
                {
                    count++;
                    if (count == 3)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"{word} ");
                        }
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
