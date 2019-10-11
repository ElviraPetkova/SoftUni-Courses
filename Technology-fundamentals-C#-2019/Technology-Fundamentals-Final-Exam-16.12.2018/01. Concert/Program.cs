using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfBandAndMembers = new Dictionary<string, List<string>>();
            //key = nameOfBand, value = list of members
            Dictionary<string, long> bandsAndTime = new Dictionary<string, long>(); //key = band, value = time

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "start of concert")
                {
                    break;
                }

                string[] tokens = input.Split("; ");
                string command = tokens[0];
                string nameOfBand = tokens[1];

                if (command == "Add")
                {
                    //Add; {bandName}; {member 1}, {member 2}, {member 3}"

                    string[] members = tokens[2].Split(", ");

                    if (listOfBandAndMembers.ContainsKey(nameOfBand) == false)
                    {
                        listOfBandAndMembers.Add(nameOfBand, new List<string>());
                        listOfBandAndMembers[nameOfBand].AddRange(members);
                    }
                    else
                    {
                        AddMembersInBand(listOfBandAndMembers, members, nameOfBand);
                    }
                }
                else if(command == "Play")
                {
                    //Play; {bandName}; {time}

                    long time = long.Parse(tokens[2]);

                    if(bandsAndTime.ContainsKey(nameOfBand) == false)
                    {
                        bandsAndTime.Add(nameOfBand, 0);
                    }

                    bandsAndTime[nameOfBand] += time;
                }
            }

            string bandName = Console.ReadLine();

            var resultBand = bandsAndTime.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToList();

            long totalTime = bandsAndTime.Select(x => x.Value).Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var kvp in resultBand)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine(bandName);
            var oneBandMembers = listOfBandAndMembers[bandName].ToList();
            foreach (var member in oneBandMembers)
            {
                Console.WriteLine($"=> {member}");
            }
        }

        private static void AddMembersInBand(Dictionary<string, List<string>> listOfBandAndMembers, string[] members, string nameOfBand)
        {
            for (int i = 0; i < members.Length; i++) 
            {
                string member = members[i];
                if(listOfBandAndMembers[nameOfBand].Contains(member) == false)
                {
                    listOfBandAndMembers[nameOfBand].Add(member);
                }
            }

        }
    }
}
