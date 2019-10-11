using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Ranking_second_solution
{
    class User
    {
        public string Name { get; set; }

        public int TotalPoints { get; set; }

        public Dictionary<string, int> Contests { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryFromContests = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                var tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];

                dictionaryFromContests.Add(contest, password);
            }

            var infoForUsers = new Dictionary<string, User>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
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
                    if (dictionaryFromContests[contest] == password)
                    {
                        if(infoForUsers.ContainsKey(user) == false)
                        {
                            User newUser = new User()
                            {
                                Name = user,
                                TotalPoints = points,
                                Contests = new Dictionary<string, int>()
                            };

                            newUser.Contests.Add(contest, points);

                            infoForUsers.Add(user, newUser);
                        }
                        else
                        {
                            if(infoForUsers[user].Contests.ContainsKey(contest) == false)
                            {
                                infoForUsers[user].Contests.Add(contest, points);
                                infoForUsers[user].TotalPoints += points;
                            }
                            else
                            {
                                if(infoForUsers[user].Contests[contest] < points)
                                {
                                    int oldPoints = infoForUsers[user].Contests[contest];
                                    infoForUsers[user].Contests[contest] = points;

                                    infoForUsers[user].TotalPoints -= oldPoints;
                                    infoForUsers[user].TotalPoints += points;
                                }
                            }
                        }
                       
                    }
                }
            }

            int maxPoints = infoForUsers.Max(x => x.Value.TotalPoints);
            string winner = string.Empty;

            foreach (var kvp in infoForUsers)
            {
                string user = kvp.Key;
                int totalPoints = kvp.Value.TotalPoints;

                if(totalPoints == maxPoints)
                {
                    winner = user;
                    break;
                }
            }

            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvp in infoForUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var contest in kvp.Value.Contests.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
