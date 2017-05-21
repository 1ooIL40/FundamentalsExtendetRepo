namespace _04.Group_Continents__Countries_and_Cities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cityInTownInContinent = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();


            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split();
                var continent = inputData[0];
                var country = inputData[1];
                var city = inputData[2];
                AddContitnentCounrtyCityOrdered(cityInTownInContinent, continent, country, city);
            }


            foreach (var continent in cityInTownInContinent)
            {
                var continents = continent.Key;
                var countrys = continent.Value;

                Console.WriteLine($"{continents}:");


                foreach (var town in countrys)
                {
                    var country = town.Key;
                    var towns = town.Value;

                    Console.WriteLine($"{country} -> {string.Join(", ",towns)}");
                }
            }
        }

        private static void AddContitnentCounrtyCityOrdered(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> cityInTownInContinent, string continent, string country, string city)
        {
            if (!cityInTownInContinent.ContainsKey(continent))
            {
                cityInTownInContinent[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!cityInTownInContinent[continent].ContainsKey(country))
            {
                cityInTownInContinent[continent][country] = new SortedSet<string>();
            }
            cityInTownInContinent[continent][country].Add(city);
        }
    }
}
