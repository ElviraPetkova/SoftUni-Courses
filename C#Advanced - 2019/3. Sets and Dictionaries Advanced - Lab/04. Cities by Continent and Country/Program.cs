using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            //key = continent, key = country, value= list of city

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = info[0];
                string contry = info[1];
                string city = info[2];

                if(dictionary.ContainsKey(continent) == false)
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                }

                if(dictionary[continent].ContainsKey(contry) == false)
                {
                    dictionary[continent].Add(contry, new List<string>());
                }

                dictionary[continent][contry].Add(city);
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var contry in kvp.Value)
                {
                    Console.WriteLine($"    {contry.Key} -> {string.Join(", ", contry.Value)}");
                }
            }
        }
    }
}
