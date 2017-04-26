namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            //var numbersArray = new int[100];
            //numbersArray[0] = 1;
            //numbersArray[1] = 2;
            //numbersArray[2] = 3;

            //var numbers = new List<int>();

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            //var words = new List<string>
            //{
            //    "Pesho", "Ivan", "Gosho"
            //};

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            ////words.Add("Pesho");
            ////words.Add("Gosho");
            ////words.Add("Vankata");

            //var numbers = new List<int>
            //{
            //    1, 2, 3, 4, 5
            //};

            //var countOfNumbers = numbers.Count; // Count == Lenght

            //Console.WriteLine(countOfNumbers);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var text = new List<string>
            //{
            //    "Pesho", "Gosho", "Ivan","Ani"
            //};

            ////text.Remove("Gosho");
            ////text.RemoveAt(0);                  //Extremely slow operation
            ////text.Insert(1, "Stamat");          //Extremely slow operation

            //foreach (var word in text)
            //{
            //    Console.WriteLine(word);
            //}

            //var number = new List<int>();

            //for (int i = 0; i < 100; i++)
            //{
            //    number.Add(i);
            //}
            //bool exists = number.Contains(5);

            //Console.WriteLine(exists);

            //var numbers = new List<int>
            //{
            //    4, 6, 1, 3, 100, 0
            //};

            //numbers.Sort();
            //numbers.Reverse();

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var n = int.Parse(Console.ReadLine());

            //var list = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    var currentNumber = int.Parse(Console.ReadLine());
            //    list.Add(currentNumber);
            //}


            // 1 2 3 4 5 6

            //var numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToList();


            //var numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' },
            //    StringSplitOptions.RemoveEmptyEntries)
            //    .Select(decimal.Parse)
            //    .ToList();

            //numbers.Sort();
            //Console.WriteLine(string.Join(" ",numbers));


            //var numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' },
            //    StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //var result = new List<int>();


            //foreach (var number in numbers)
            //{
            //    var square = Math.Sqrt(number);

            //    if (square == (int)square)
            //    {
            //        result.Add(number);
            //    }
            //}

            //result.Sort();
            //result.Reverse();

            //Console.WriteLine(string.Join(" ", result));



            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var count = new int[1001];

            foreach (var number in numbers)
            {
                count[number]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
