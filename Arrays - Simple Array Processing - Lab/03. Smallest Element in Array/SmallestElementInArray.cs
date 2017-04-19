
namespace _03.Smallest_Element_in_Array
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var givenArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var smallest = int.MaxValue;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (smallest > givenArray[i])
                {
                    smallest = givenArray[i];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
