
namespace Demo
{
    using System;
    using System.Linq;

    public class Demo
    {
        public static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7
            //var text = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToArray();

            //var text = "1 2 3 4 5 6  7 ";
            ////For spliting the extra spaces
            //var parts = text.Split(
            //    new char[] { ' ' },
            //    StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();


            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
