using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryFromContests = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of contests")
                {
                    break;
                }

                var tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];

                dictionaryFromContests.Add(contest, password);
            }

            var infoForUsers = new Dictionary<string, Dictionary<string, int>>();
            //key = user, value => key = contest, value = points

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of submissions")
                {
                    break;
                }

                var tokens = input.Split("=>");

                string contest = tokens[0];
                string password = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);

                if (dictionaryFromContests.ContainsKey(contest))
                {
                    if(dictionaryFromContests[contest] == password)
                    {
                        if(infoForUsers.ContainsKey(user) == false)
                        {
                            infoForUsers.Add(user, new Dictionary<string, int>());
                            infoForUsers[user].Add(contest, points);
                        }
                        else
                        {
                            if(infoForUsers[user].ContainsKey(contest) == false)
                            {
                                infoForUsers[user].Add(contest, points);
                            }
                            else
                            {
                                if(infoForUsers[user][contest] < points)
                                {
                                    infoForUsers[user][contest] = points;
                                }
                            }
                        }
                    }
                }
            }

            //int maxPoints = infoForUsers.Max(x => x.Value.Values.Sum());

            int maxPoints = 0;
            string winner = string.Empty;

            foreach (var kvp in infoForUsers)
            {
                string user = kvp.Key;
                int allPoints = kvp.Value.Values.Sum();

                if(maxPoints < allPoints)
                {
                    maxPoints = allPoints;
                    winner = user;
                }
            }

            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvp in infoForUsers.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var contest in kvp.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }
    }
}
