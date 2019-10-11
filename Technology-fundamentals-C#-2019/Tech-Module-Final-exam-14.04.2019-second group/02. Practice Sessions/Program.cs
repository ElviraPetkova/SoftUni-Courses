using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }

                var tokens = input.Split("->");
                string command = tokens[0];

                if(command == "Add")
                {
                    string road = tokens[1];
                    string racer = tokens[2];

                    if(dictionary.ContainsKey(road) == false)
                    {
                        dictionary.Add(road, new List<string>());
                    }

                    dictionary[road].Add(racer);
                }
                else if(command == "Move")
                {
                    string currentRoad = tokens[1];
                    string racer = tokens[2];
                    string nextRoad = tokens[3];

                    var listOfRacersOfCurrentRoad = dictionary[currentRoad].ToList();
                    if (listOfRacersOfCurrentRoad.Contains(racer))
                    {
                        dictionary[currentRoad].Remove(racer);
                        dictionary[nextRoad].Add(racer);
                    }
                }
                else if(command == "Close")
                {
                    string road = tokens[1];
                    if (dictionary.ContainsKey(road))
                    {
                        dictionary.Remove(road);
                    }
                }
            }

            var result = dictionary
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToList();

            Console.WriteLine("Practice sessions:");
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
                foreach (var racer in kvp.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
