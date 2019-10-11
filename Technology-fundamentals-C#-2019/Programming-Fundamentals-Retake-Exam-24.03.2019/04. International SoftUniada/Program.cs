using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._International_SoftUniada
{
    class Contestant
    {
        public string Name { get; set; }

        public int Points { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var contestantsAndPoints = new Dictionary<string, List<Contestant>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                var splitedInput = input.Split(" -> ");

                string countryName = splitedInput[0];
                string contestantName = splitedInput[1];
                int contestantPoints = int.Parse(splitedInput[2]);

                if(contestantsAndPoints.ContainsKey(countryName) == false)
                {
                    contestantsAndPoints.Add(countryName, new List<Contestant>());

                    Contestant contestant = new Contestant()
                    {
                        Name = contestantName,
                        Points = contestantPoints
                    };

                    contestantsAndPoints[countryName].Add(contestant);
                }
                else
                {
                    var listOfContestansPerOneCountry = contestantsAndPoints[countryName].ToList();
                    bool isHaveContestantName = ChekingForThisName(listOfContestansPerOneCountry, contestantName, contestantPoints);
                    if(isHaveContestantName == false)
                    {
                        Contestant contestant = new Contestant()
                        {
                            Name = contestantName,
                            Points = contestantPoints
                        };

                        contestantsAndPoints[countryName].Add(contestant);
                    }
                }

            }

            var result = contestantsAndPoints
                .OrderByDescending(x => x.Value.Sum(y => y.Points));

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Sum(x=>x.Points)}");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($" -- {item.Name} -> {item.Points}");
                }
            }

        }

        private static bool ChekingForThisName(List<Contestant> listOfContestansPerOneCountry, string contestantName, int point)
        {
            bool isHaveName = false;

            foreach (var contestant in listOfContestansPerOneCountry)
            {
                if(contestant.Name == contestantName)
                {
                    isHaveName = true;
                    contestant.Points += point;
                    break;
                }
            }

            return isHaveName;
        }
    }
}
