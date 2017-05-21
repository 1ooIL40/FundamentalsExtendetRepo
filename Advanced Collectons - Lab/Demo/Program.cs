namespace Demo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            //var grades = new Dictionary<string, List<int>>();

            //AddGrade(grades, "Gosho", 5);
            //AddGrade(grades, "Kiro", 6);
            //AddGrade(grades, "Gosho", 2);
            //AddGrade(grades, "Kiro", 2);
            //AddGrade(grades, "Maria", 4);
            //AddGrade(grades, "Maria", 4);
            //AddGrade(grades, "Gosho", 6);

            //foreach (var nameAndGrade in grades)
            //{
            //    Console.WriteLine("{0} -> {1}",
            //        nameAndGrade.Key,
            //        string.Join(" ",nameAndGrade.Value));
            //}

            //PrintGrades(grades);






            //var n = int.Parse(Console.ReadLine());
            //var grades = new Dictionary<string, List<double>>();


            //for (int i = 0; i < n; i++)
            //{
            //    var nameAndGrade = Console.ReadLine().Split(' ');
            //    var name = nameAndGrade[0];
            //    var grade = double.Parse(nameAndGrade[1]);

            //    if (!grades.ContainsKey(name))
            //    {
            //        grades[name] = new List<double>();
            //    }
            //    grades[name].Add(grade);
            //}

            //foreach (var nameAndGrades in grades)
            //{
            //    var gradesList = new List<string>();
            //    var sumGrade = 0d;
            //    var gradesCount = 0;

            //    foreach (var grade in nameAndGrades.Value)
            //    {
            //        var gradeStr = string.Format("{0:f2}", grade);
            //        gradesList.Add(gradeStr);
            //        gradesCount++;
            //        sumGrade += grade;
            //    }

            //    Console.WriteLine("{0} -> {1} (avg: {2:f2})",
            //        nameAndGrades.Key,
            //        string.Join(" ",gradesList),
            //        sumGrade / gradesCount);
            //}



            // country_code -> town -> popilation

            //var population = new Dictionary<string, Dictionary<string, int>>();


            //AdddPopulation(population, "Bulgaria", "Sofia", 1200000);
            //AdddPopulation(population, "Bulgaria", "Plovdiv", 700000);

            //AdddPopulation(population, "Germany", "Miunhen", 2500000);
            //AdddPopulation(population, "Germany", "Berlin", 1500000);

            //AdddPopulation(population, "USA", "New Yorl", 1100000);


            ////Remove city
            //population["Bulgaria"].Remove("Plovdiv");


            //foreach (var country in population.Keys)
            //{
            //    Console.WriteLine("Country {0}:",country);
            //    var populationByTown = population[country];
            //    foreach (var town in populationByTown.Keys)
            //    {
            //        Console.WriteLine("  Town '{0}' -> {1} citizens",
            //            town,
            //            populationByTown[town]);
            //    }
            //}



            //Contient -> countrys -> towns

            //var townsDict = new Dictionary<string, Dictionary<string, List<string>>>();

            ////AddTown(towns, "Europe", "Bulgaria", "Sofia");
            ////AddTown(towns, "Europe", "Bulgaria", "Plovdiv");
            ////AddTown(towns, "North America", "USA", "New Yor");
            ////AddTown(towns, "Europe", "Bulgaria", "Ruse");
            ////AddTown(towns, "North America", "USA", "Los Angeles");
            ////AddTown(towns, "Europe", "Germany", "Berlin");
            ////AddTown(towns, "North America", "USA", "Pittsburg");
            ////AddTown(towns, "North America", "Canada", "Montreal");
            ////AddTown(towns, "Asia", "China", "Bejing");


            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var lineData = Console.ReadLine().Split();
            //    var contient = lineData[0];
            //    var contry = lineData[1];
            //    var town = lineData[2];

            //    AddTown(townsDict,contient, contry, town);
            //}


            //foreach (var contitnent in townsDict.Keys)
            //{
            //    Console.WriteLine("{0}:", contitnent);

            //    var townsInContinent = townsDict[contitnent];

            //    foreach (var country in townsInContinent.Keys)
            //    {
            //        Console.WriteLine(" {0} -> {1}",
            //            country,
            //            string.Join(", ",townsInContinent[country]));
            //    }
            //}



            // Hash Set

            //var list = new List<string>();
            //var set = new HashSet<string>();


            //list.Add("Sofia");
            //list.Add("Plovdiv");
            //list.Add("Burgas");
            //list.Add("Plovdiv");
            //Console.WriteLine(string.Join(", ",list));


            //set.Add("Sofia");
            //set.Add("Plovdiv");
            //set.Add("Burgas");
            //set.Add("Plovdiv");
            //set.Add("Aytos");
            //Console.WriteLine(string.Join(", ", set));



            //var n = int.Parse(Console.ReadLine());
            //var set = new HashSet<string>();

            //for (int i = 0; i < n; i++)
            //{
            //    var name = Console.ReadLine();
            //    set.Add(name);
            //}

            //Console.WriteLine(string.Join(Environment.NewLine, set));



            //var data = new SortedDictionary<string, 
            //    SortedDictionary<string, SortedSet<string>>>();

            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var tokens = Console.ReadLine().Split(' ');
            //    var continent = tokens[0];
            //    var country = tokens[1];
            //    var town = tokens[2];

            //    if (!data.ContainsKey(continent))
            //    {
            //        data[continent] = new SortedDictionary<string,
            //            SortedSet<string>>();
            //    }

            //    if (!data[continent].ContainsKey(country))
            //    {
            //        data[continent][country] = new SortedSet<string>();
            //    }

            //    data[continent][country].Add(town);
            //}

            //foreach (var continentAndCountries in data)
            //{
            //    var continentName = continentAndCountries.Key;
            //    var townsByCountry = continentAndCountries.Value;

            //    Console.WriteLine($"{continentName}:");

            //    foreach (var item in townsByCountry)
            //    {
            //        var country = item.Key;
            //        var towns = item.Value;

            //        Console.WriteLine($"  {country} -> {string.Join(", ",towns)}");
            //    }
            //}






        }

        static void AddTown(Dictionary<string, Dictionary<string, List<string>>> towns, string continent, string contrys, string town)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new Dictionary<string, List<string>>();
            }

            if (!towns[continent].ContainsKey(contrys))
            {
                towns[continent][contrys] = new List<string>();
            }
            towns[continent][contrys].Add(town);
        }

        static void AdddPopulation(
            Dictionary<string, Dictionary<string, int>> population, 
            string country, string town, int townPopulation)
        {
            if (!population.ContainsKey(country))
            {
                population[country] = new Dictionary<string, int>();
            }
            population[country][town] = townPopulation;
        }

        static void PrintGrades(Dictionary<string, List<int>> grades)
        {
            foreach (var name in grades.Keys)
            {
                Console.WriteLine("Grades of " + name + ":");
                foreach (var grade in grades[name])
                {
                    Console.WriteLine(" - " + grade);
                }
            }
        }

        static void AddGrade(Dictionary<string, List<int>> grades,
            string name, int grade)
        {
            if (!grades.ContainsKey(name))
            {
                grades[name] = new List<int>();
            }
            grades[name].Add(grade);
        }
    }
}
