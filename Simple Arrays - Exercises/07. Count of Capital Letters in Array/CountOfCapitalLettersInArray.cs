
namespace _07.Count_of_Capital_Letters_in_Array
{
    using System;
    using System.Linq;

    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            var arrayOfStringElements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var len = arrayOfStringElements.Length;
            var count = 0;

            for (int i = 0; i < len; i++)
            {
                try
                {
                    char chars = char.Parse(arrayOfStringElements[i]);
                    if (chars >= 65 && chars <= 90)
                    {
                        count++;
                    }
                }
                catch (Exception)
                {
                }
            }
            Console.WriteLine(count);
        }
    }
}
