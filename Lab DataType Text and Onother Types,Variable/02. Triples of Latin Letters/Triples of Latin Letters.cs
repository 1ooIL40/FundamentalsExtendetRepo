
namespace _02.Triples_of_Latin_Letters
{
    using System;
    public class TriplesLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        Console.WriteLine($"{(char)(first + 97)}{(char)(second + 97)}{(char)(third + 97)}");
                    }
                }
            }
        }
    }
}
