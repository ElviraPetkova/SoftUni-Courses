using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>(); //key = user, value = side

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    var tokens = input.Split(" | ");
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if(users.ContainsKey(forceUser) == false)
                    {
                        users.Add(forceUser, forceSide);
                    }
                }
                else if (input.Contains("->"))
                {
                    var tokens = input.Split(" -> ");
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];

                    if(users.ContainsKey(forceUser) == false)
                    {
                        users.Add(forceUser, forceSide);
                    }
                    else
                    {
                        if(users[forceUser] != forceSide)
                        {
                            users[forceUser] = forceSide;
                        }
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            var result = users
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .ToList();

            foreach (var side in result)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Count()}");
                foreach (var user in side.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"! {user.Key}");
                }
            }
        }
    }
}
