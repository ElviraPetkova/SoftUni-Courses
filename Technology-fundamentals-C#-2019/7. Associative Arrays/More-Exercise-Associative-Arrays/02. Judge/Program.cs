using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{

    class Program
    {
        static void Main(string[] args)
        {
            var judge = new Dictionary<string, Dictionary<string, int>>();
            //key = contest, value=> key = user, value = points

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "no more time")
                {
                    break;
                }

                var tokens = input.Split(" -> ");

                string user = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if(judge.ContainsKey(contest) == false)
                {
                    judge.Add(contest, new Dictionary<string, int>());
                    judge[contest].Add(user, points);
                }
                else
                {
                    if(judge[contest].ContainsKey(user) == false)
                    {
                        judge[contest].Add(user, points);
                    }
                    else
                    {
                        if(judge[contest][user] < points)
                        {
                            judge[contest][user] = points;
                        }
                    }
                }
            }

            foreach (var kvp in judge)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");

                int position = 1;
                foreach (var user in kvp.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{position}. {user.Key} <::> {user.Value}");
                    position++;
                }
            }

            Dictionary<string, int> listOtUsers = ListOfAllUsers(judge);

            Console.WriteLine("Individual standings:");

            int place = 1;
            foreach (var kvp in listOtUsers.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{place}. {kvp.Key} -> {kvp.Value}");
                place++;
            }
        }

        private static Dictionary<string, int> ListOfAllUsers(Dictionary<string, Dictionary<string, int>> judge)
        {
            var allUsers = new Dictionary<string, int>();

            foreach (var kvp in judge)
            {
                foreach (var user in kvp.Value)
                {
                    string userName = user.Key;
                    int points = user.Value;

                    if(allUsers.ContainsKey(userName) == false)
                    {
                        allUsers.Add(userName, points);
                    }
                    else
                    {
                        allUsers[userName] += points;
                    }
                }
            }

            return allUsers;
        }
    }
}
