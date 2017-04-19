
namespace _06.Equal_Sequence_of_Elements_in_Array
{
    using System;
    using System.Linq;

    public class EqualSequenceIfElementsInArray
    {
        public static void Main()
        {
            var arrayOfElements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var len = arrayOfElements.Length;
            var isTrue = false;

            for (int i = 0; i < len-1; i++)
            {
                if (arrayOfElements[i] == arrayOfElements[i + 1])
                {
                    isTrue = true;
                }
                else
                {
                    break;
                }
            }
            if (isTrue)
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
