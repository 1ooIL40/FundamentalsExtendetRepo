namespace _03.Increasing_Crisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            // 80/100 judge
            var numberOfLines = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            var line = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
                

            

            while (numberOfLines > 1)
            {
                input = Console.ReadLine();

                var secondLine = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                secondLine.Add(int.MaxValue);

                for (int i = 0; i < secondLine.Count - 1; i++)
                {
                    var first = secondLine[i];
                    var second = secondLine[i + 1];

                    if (first <= second)
                    {
                        line = InsertElement(line, first);
                    }

                    else if (first > second)
                    {


                        for (int position = 0; position < line.Count; position++)
                        {

                            if (first < line[position])
                            {
                                line.RemoveAt(position);
                                position--;
                            }
                        }
                        line.Add(first);
                        break;
                    }
                }

                secondLine.RemoveAt(secondLine.Count - 1);

                numberOfLines--;
            }

            
            Console.WriteLine(string.Join(" ", line));
        }

        static List<int> InsertElement(List<int> line, int first)
        {
            line.Add(int.MaxValue);

            for (int position = 0; position < line.Count; position++)
            {
                if (first <= line[position])
                {
                    line.Insert(position, first);
                    break;
                }
            }
            line.Remove(int.MaxValue);

            return line;
        }
    }
}

