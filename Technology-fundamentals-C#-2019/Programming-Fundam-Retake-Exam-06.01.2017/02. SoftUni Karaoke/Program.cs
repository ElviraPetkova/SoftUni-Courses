using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfParticipants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> listOfSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> allPeople = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "dawn")
                {
                    break;
                }

                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if(listOfParticipants.Contains(participant) && listOfSongs.Contains(song))
                {
                    if(allPeople.ContainsKey(participant) == false)
                    {
                        allPeople.Add(participant, new List<string>());
                        allPeople[participant].Add(award);
                    }
                    else
                    {
                        if(allPeople[participant].Contains(award) == false)
                        {
                            allPeople[participant].Add(award);
                        }
                    }
 
                }
            }

            if(allPeople.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                var result = allPeople.OrderByDescending(a => a.Value.Count).ThenBy(p => p.Key).ToList();

                foreach (var kvp in result)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");
                    foreach (var award in kvp.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
