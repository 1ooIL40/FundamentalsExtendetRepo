namespace _01.Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nameAndGrades = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var tokens = input.Split();
                var name = tokens[0];
                var grades = double.Parse(tokens[1]);

                if (!nameAndGrades.ContainsKey(name))
                {
                    nameAndGrades[name] = new List<double>();
                }
                nameAndGrades[name].Add(grades);
            }

            foreach (var name in nameAndGrades)
            {
                var nameOfStudent = name.Key;
                var gradesOfStudent = name.Value;
                var avg = 0d;
                Console.Write($"{nameOfStudent} -> ");
                foreach (var grade in gradesOfStudent)
                {
                    avg = gradesOfStudent.Average();
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {avg:f2})");
            }
        }
    }
}
