using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggersAndFollowers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vloggerName = tokens[0];
                string action = tokens[1];

                if (action == "joined")
                {
                    if (vloggersAndFollowers.ContainsKey(vloggerName) == false)
                    {
                        vloggersAndFollowers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        vloggersAndFollowers[vloggerName].Add("followers", new HashSet<string>());
                        vloggersAndFollowers[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else if (action == "followed")
                {
                    string member = tokens[2];

                    if (vloggerName == member)
                    {
                        continue;
                    }

                    //•	"{vloggername} followed {vloggername}" 

                    if (vloggerName != member && vloggersAndFollowers.ContainsKey(vloggerName) && vloggersAndFollowers.ContainsKey(member))
                    {
                        vloggersAndFollowers[vloggerName]["following"].Add(member);
                        vloggersAndFollowers[member]["followers"].Add(vloggerName);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggersAndFollowers.Keys.Count} vloggers in its logs.");

            int count = 1;

            var statistics = vloggersAndFollowers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToList();

            foreach (var kvp in statistics)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");
                if (count == 1)
                {
                    foreach (var item in kvp.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                count++;
            }

            //30/100 => incorrect sorting
            //var vloggersAndFollowers = new Dictionary<string, List<string>>();
            //var vloggersAndFollowing = new Dictionary<string, List<string>>();

            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if(input == "Statistics")
            //    {
            //        break;
            //    }

            //    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string vloggerName = tokens[0];
            //    string action = tokens[1];

            //    if(action == "joined")
            //    {
            //        if(vloggersAndFollowers.ContainsKey(vloggerName) == false)
            //        {
            //            vloggersAndFollowers.Add(vloggerName, new List<string>());
            //            vloggersAndFollowing.Add(vloggerName, new List<string>());
            //        }
            //    }
            //    else if(action == "followed")
            //    {
            //        string secondVloggerName = tokens[2];

            //        if (vloggerName == secondVloggerName)
            //        {
            //            continue;
            //        }

            //        //•	"{vloggername} followed {vloggername}" 

            //        if (vloggersAndFollowers.ContainsKey(secondVloggerName) && vloggersAndFollowing.ContainsKey(vloggerName))
            //        {
            //            if(vloggersAndFollowers[secondVloggerName].Contains(vloggerName) == false)
            //            {
            //                vloggersAndFollowers[secondVloggerName].Add(vloggerName);
            //                vloggersAndFollowing[vloggerName].Add(secondVloggerName);
            //            }
            //        }                   
            //    }
            //}

            //Console.WriteLine($"The V-Logger has a total of {vloggersAndFollowers.Keys.Count} vloggers in its logs.");

            //int count = 1;

            //var statistics = vloggersAndFollowers
            //    .OrderByDescending(x => x.Value.Count)
            //    .ThenBy(x=>vloggersAndFollowing.Keys.Count)
            //    .ToList();



            //foreach (var kvp in statistics)
            //{
            //    int followingCount = vloggersAndFollowing[kvp.Key].Count;
            //    Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} followers, {followingCount} following");
            //    if(count == 1)
            //    {
            //        foreach (var item in kvp.Value.OrderBy(x=>x))
            //        {
            //            Console.WriteLine($"*  {item}");
            //        }
            //    }
            //    count++;
            //}
        }
    }
}
