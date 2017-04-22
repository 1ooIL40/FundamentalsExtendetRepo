
namespace _05.Char_Rotation
{
    using System;
    using System.Linq;

    public class CharRotation
    {
        public static void Main()
        {
            var text =  "tszL"; //"$wM+J_H";
            var textNumbers = "18 10 8 21";//"47 8 25 73 11 15 33";// 
            var stringArray = text//Console.ReadLine()
                 .ToCharArray();
            var numbers = textNumbers//Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            ModifiedOtput(stringArray, numbers);
        }

        static void ModifiedOtput(char[] stringArray, int[] numbers)
        {
            var len = stringArray.Length;
            var answer = string.Empty;

            for (int i = 0; i < len; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    var result = Math.Abs(numbers[i] - stringArray[i]);
                    answer += (char)result;
                }
                else if (numbers[i] % 2 != 0)
                {
                    var result = Math.Abs(numbers[i] + stringArray[i]);
                    answer += (char)result;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
