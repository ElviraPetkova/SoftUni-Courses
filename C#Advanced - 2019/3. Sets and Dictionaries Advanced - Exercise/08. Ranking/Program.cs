using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataOfCourses = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of contests")
                {
                    break;
                }

                string[] toknes = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contest = toknes[0];
                string password = toknes[1];

                dataOfCourses.Add(contest, password); //not cheking key contest
            }

            var users = new Dictionary<string, Dictionary<string, int>>();
            //key=userName, key = contest, value = points

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of submissions")
                {
                    break;
                }

                string[] tokens = input.Split("=>"); //"{contest}=>{password}=>{username}=>{points}" 
                string contest = tokens[0];
                string password = tokens[1];
                string userName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (dataOfCourses.ContainsKey(contest))
                {
                    if(dataOfCourses[contest] == password)
                    {
                        if(users.ContainsKey(userName) == false)
                        {
                            users.Add(userName, new Dictionary<string, int>());
                        }

                        if(users[userName].ContainsKey(contest) == false)
                        {
                            users[userName].Add(contest, points);
                        }
                        else
                        {
                            if(users[userName][contest] < points)
                            {
                                users[userName][contest] = points;
                            }
                        }
                    }
                }
            }

            KeyValuePair<string, int> bestUser = BestUser(users);
            Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value} points.");
            Console.WriteLine("Ranking:");

            foreach (var kvp in users.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var contest in kvp.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        private static KeyValuePair<string, int> BestUser(Dictionary<string, Dictionary<string, int>> users)
        {
            int bestSum = 0;
            string userOfBest = string.Empty;

            foreach (var kvp in users)
            {
                string userName = kvp.Key;
                int sumOfPoints = kvp.Value.Values.Sum();

                if (bestSum < sumOfPoints)
                {
                    bestSum = sumOfPoints;
                    userOfBest = userName;
                }
            }

            KeyValuePair<string, int> bestUser = new KeyValuePair<string, int>(userOfBest, bestSum);
            return bestUser;
        }
    }
}
