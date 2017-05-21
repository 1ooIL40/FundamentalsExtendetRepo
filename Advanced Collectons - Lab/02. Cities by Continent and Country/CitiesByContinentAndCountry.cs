namespace _02.Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cityInCountryInContinent = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var continetsCountriesCities = Console.ReadLine().Split();

                var continents = continetsCountriesCities[0];
                var countries = continetsCountriesCities[1];
                var cities = continetsCountriesCities[2];
                AddContinentCountryTown(cityInCountryInContinent, continents, countries, cities);
            }

            foreach (var continents in cityInCountryInContinent)
            {
                var continent = continents.Key;
                var countries = continents.Value;

                Console.WriteLine($"{continent}:");

                foreach (var towns in countries)
                {
                    var coutry = towns.Key;
                    var town = towns.Value;

                    Console.WriteLine($"{coutry} -> {string.Join(", ", town)}");
                }

            }
        }

        static void AddContinentCountryTown(Dictionary<string, Dictionary<string, List<string>>> cityInCountryInContinent, string continents, string countries, string cities)
        {
            if (!cityInCountryInContinent.ContainsKey(continents))
            {
                cityInCountryInContinent[continents] = new Dictionary<string, List<string>>();
            }
            if (!cityInCountryInContinent[continents].ContainsKey(countries))
            {
                cityInCountryInContinent[continents][countries] = new List<string>();
            }

            cityInCountryInContinent[continents][countries].Add(cities);
        }
    }
}
