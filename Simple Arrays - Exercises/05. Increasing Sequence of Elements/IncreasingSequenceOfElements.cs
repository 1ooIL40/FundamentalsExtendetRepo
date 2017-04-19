
namespace _05.Increasing_Sequence_of_Elements
{
    using System;
    using System.Linq;

    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            var arrayOfElements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var len = arrayOfElements.Length;
            bool isTrue = false;

            for (int i = 0; i < len-1; i++)
            {
                if (arrayOfElements[i] <= arrayOfElements[i + 1])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
