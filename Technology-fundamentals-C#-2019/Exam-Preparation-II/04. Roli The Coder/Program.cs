using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> idEventsAndNames = new Dictionary<int, string>(); //key = id, value = name
            Dictionary<int, List<string>> nameEventsAndListOfParticipants = new Dictionary<int, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Time for Code")
                {
                    break;
                }

                var events = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int idEvent = 0;

                if(int.TryParse(events[0], out idEvent) == false)
                {
                    continue;
                }

                string nameOfEvent = events[1];
                if(nameOfEvent.StartsWith("#") == false)
                {
                    continue;
                }
                nameOfEvent = nameOfEvent.Trim('#');

                bool isParticipiant = false;
                var listOfParticipiants = new List<string>();
                for (int i = 2; i < events.Length; i++)
                {
                    string participiant = events[i];
                    if (participiant.StartsWith("@") == false)
                    {
                        isParticipiant = true;
                        break;
                    }

                    listOfParticipiants.Add(participiant);
                }

                if (isParticipiant)
                {
                    continue;
                }

                if(idEventsAndNames.ContainsKey(idEvent) == false)
                {
                    idEventsAndNames.Add(idEvent, nameOfEvent);
                    nameEventsAndListOfParticipants.Add(idEvent, new List<string>());
                    nameEventsAndListOfParticipants[idEvent].AddRange(listOfParticipiants);
                }
                else
                {
                    if(nameOfEvent == idEventsAndNames[idEvent])
                    {
                        nameEventsAndListOfParticipants[idEvent].AddRange(listOfParticipiants);
                    }
                }

                nameEventsAndListOfParticipants[idEvent] = nameEventsAndListOfParticipants[idEvent].Distinct().ToList();
            }

            var result = nameEventsAndListOfParticipants
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => idEventsAndNames[x.Key]);

            foreach (var ev in result)
            {
                int id = ev.Key;
                string name = idEventsAndNames[id];
                int count = ev.Value.Count();

                Console.WriteLine($"{name} - {count}");

                foreach (var participant in ev.Value.OrderBy(x=>x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
