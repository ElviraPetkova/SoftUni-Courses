using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Iron_Girder
{
    class Town
    {
        public string Name { get; set; }

        public int Time { get; set; }

        public int CountOfPassage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var towns = new Dictionary<string, Town>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Slide rule")
                {
                    break;
                }

                string[] tokens = input.Split(':');
                string townName = tokens[0];

                string[] splitTokens = tokens[1].Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                string timeOrAmbush = splitTokens[0];
                int passageCount = int.Parse(splitTokens[1]);

                if(timeOrAmbush == "ambush")
                {
                    if (towns.ContainsKey(townName))
                    {
                        towns[townName].Time = 0;
                        towns[townName].CountOfPassage -= passageCount;
                    }
                }
                else
                {
                    int time = int.Parse(timeOrAmbush);

                    if(towns.ContainsKey(townName) == false)
                    {
                        Town currentTown = new Town()
                        {
                            Name = townName,
                            Time = time,
                            CountOfPassage = passageCount
                        };

                        towns.Add(townName, currentTown);
                    }
                    else
                    {
                        towns[townName].CountOfPassage += passageCount;
                        if(towns[townName].Time > time)
                        {
                            towns[townName].Time = time;
                        }

                        if(towns[townName].Time == 0)
                        {
                            towns[townName].Time = time;
                        }
                    }
                }
            }

            var result = towns
                .Where(x => x.Value.Time > 0)
                .Where(x => x.Value.CountOfPassage > 0)
                .OrderBy(x => x.Value.Time)
                .ThenBy(x => x.Key)
                .ToList();

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> Time: {kvp.Value.Time} -> Passengers: {kvp.Value.CountOfPassage}");
            }
        }
    }
}
