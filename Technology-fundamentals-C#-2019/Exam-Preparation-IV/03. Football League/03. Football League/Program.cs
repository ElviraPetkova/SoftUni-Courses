using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace _03._Football_League
{
    class Program
    {
        public static object StringHelper { get; private set; }

        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);

            string pattern = $@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)"; //$@"([{key}]+)(?<firstTeam>[A-Za-z]+)(\1).*?(\1)(?<secondTeam>[A-Za-z]+)(\1).*?(?<result>[\d]+[:][\d]+)";
            Regex regex = new Regex(pattern);

            var teamsAndGoals = new Dictionary<string, long>(); // key = team, value = goals
            var teamsAndPoints = new Dictionary<string, long>(); // key = team, value = points => 3 for winn, 1 for equal

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "final")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    Match infoPerOneMeet = regex.Match(input);
                    string currentFirstTeam = infoPerOneMeet.Groups[1].Value;//["firstTeam"].Value;
                    string currentSecondTeam = infoPerOneMeet.Groups[2].Value;//["secondTeam"].Value;
                    //var currentResult = infoPerOneMeet.Groups["result"].Value.Split(':').Select(long.Parse).ToArray();

                    long resultFirstTeam = long.Parse(infoPerOneMeet.Groups[3].Value); //currentResult[0];
                    long resultSecondTeam = long.Parse(infoPerOneMeet.Groups[4].Value);//currentResult[1];

                    string firtTeam = ReversingStringAndChangingLetterCase(currentFirstTeam);
                    string secondTeam = ReversingStringAndChangingLetterCase(currentSecondTeam);

                    if(teamsAndGoals.ContainsKey(firtTeam) == false)
                    {
                        teamsAndGoals.Add(firtTeam, 0);
                    }

                    if(teamsAndGoals.ContainsKey(secondTeam) == false)
                    {
                        teamsAndGoals.Add(secondTeam, 0);
                    }

                    teamsAndGoals[firtTeam] += resultFirstTeam;
                    teamsAndGoals[secondTeam] += resultSecondTeam;

                    if(teamsAndPoints.ContainsKey(firtTeam) == false)
                    {
                        teamsAndPoints.Add(firtTeam, 0);
                    }

                    if(teamsAndPoints.ContainsKey(secondTeam) == false)
                    {
                        teamsAndPoints.Add(secondTeam, 0);
                    }

                    if(resultFirstTeam == resultSecondTeam)
                    {
                        teamsAndPoints[firtTeam]++;
                        teamsAndPoints[secondTeam]++;
                    }
                    else if(resultFirstTeam > resultSecondTeam)
                    {
                        teamsAndPoints[firtTeam] += 3;
                    }
                    else if(resultSecondTeam > resultFirstTeam)
                    {
                        teamsAndPoints[secondTeam] += 3;
                    }

                }
            }

            Console.WriteLine("League standings:");
            int counter = 1;
            foreach (var team in teamsAndPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{counter}. {team.Key} {team.Value}");
                counter++;
            }

            counter = 0;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamsAndGoals.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                counter++;
                if(counter == 3)
                {
                    break;
                }
            }
        }

        private static string ReversingStringAndChangingLetterCase(string currentTeam)
        {
            StringBuilder result = new StringBuilder();
            for (int i = currentTeam.Length - 1; i >= 0; i--)
            {
                result.Append(currentTeam[i].ToString().ToUpper());
            }
            return result.ToString();
        }
    }
}
