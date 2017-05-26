namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Demo
    {
        public static void Main()
        {
            //var numbers = new List<int>
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9
            //};

            //var sum = numbers.Sum();
            //var min = numbers.Min();
            //var average = number.Average();

            //Console.WriteLine(sum);
            //Console.WriteLine(min);
            //Console.WriteLine(average);



            //Sort Colections

            //var numbers = new List<int>
            //{
            //    1, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 0
            //};

            //var sortedNumbers = numbers
            //    .OrderByDescending(num => num)
            //    .ToList();


            //Console.WriteLine(string.Join(" ",sortedNumbers));

            //var myNumber = Console.ReadLine()
            //       .Split(' ')
            //       .Select(n => int.Parse(n))
            //       .ToList();   




            //var numbers = new List<int>
            //{
            //    1, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 0
            //};

            //var students = new Dictionary<string, int>()
            //{
            //    ["Ivan"] = 2,
            //    ["Pesho"] = 4,
            //    ["Gosho"] = 6,
            //    ["Maria"] = 5,
            //    ["Ani"] = 2,
            //};

            ////var sortedStudents = students
            ////    .OrderBy(st => st.Value)
            ////    .ThenBy(st => st.Key);

            //var sortedStudents = students
            //    .OrderBy(st => st.Value)
            //    .ThenBy(st => st.Key);
            ////.ToDictionary(st => st.Key, st => st.Value);

            //foreach (var student in sortedStudents)
            //{
            //    Console.WriteLine($"{student.Key} - {student.Value}");
            //}

            ////foreach (var student in students)
            ////{
            ////    Console.WriteLine($"{student.Key} - {student.Value}");
            ////}



            //Take() Skip()


            //var numbers = new List<int>
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 0
            //};

            ////var firstThree = numbers
            ////    .OrderBy(num => num)
            ////    .Take(4)
            ////    .ToList();

            //var firstThree = numbers
            //    .OrderBy(num => num)
            //    .Skip(4)
            //    .ToList();

            //Console.WriteLine(string.Join(" ",firstThree));



            //Filter Collection Where(), Count()



            //var numbers = new List<int>
            //{
            //    10, 30, 15, 20, 50, 5
            //};

            //var oddNumbers = numbers
            //    .Where(n => n % 2 == 0)
            //    .ToList();

            //var hasNumbers = numbers
            //    .All(n => n < 100);
            //    //.Any(n => n > 10);

            //if (hasNumbers)
            //{
            //    Console.WriteLine("Ima!");
            //}


            //Console.WriteLine(numbers.Count(n => n % 3 == 0));
            //Console.WriteLine(string.Join(" ",oddNumbers));



                //First(), Last(), Sigle()

            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7
            };

            var number = numbers
                .First(n => n % 2 == 0);


            Console.WriteLine(number);
        }
    }
}
