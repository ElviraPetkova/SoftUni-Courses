using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            var listOfUsers = new Dictionary<string, string>(); 

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] info = input.Split(" | ");

                    string side = info[0];
                    string user = info[1];

                    if(listOfUsers.ContainsKey(user) == false)
                    {
                        listOfUsers.Add(user, side);
                    }
                    
                }
                else if (input.Contains("->"))
                {
                    string[] info = input.Split(" -> ");

                    string user = info[0];
                    string side = info[1];

                    if (listOfUsers.ContainsKey(user))
                    {
                        if (listOfUsers[user] != side)
                        {
                            listOfUsers[user] = side;
                        }
                    }
                    else if(listOfUsers.ContainsKey(user) == false)
                    {
                        listOfUsers.Add(user, side);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");

                }
            }

            var currentResult = listOfUsers
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key);

            foreach (var side in currentResult)
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
