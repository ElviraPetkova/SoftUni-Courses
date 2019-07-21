using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] splitedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string typeCommand = splitedCommand[0];
                string filterCommand = splitedCommand[1];
                string criteria = splitedCommand[2];

                Func<string, string, bool> predicate = GetFunc(filterCommand);

                if (typeCommand == "Remove")
                {
                    listOfNames = listOfNames.Where(x => !predicate(x, criteria)).ToList();
                }
                else if(typeCommand == "Double")
                {
                    List<string> guestToAdd = new List<string>();

                    guestToAdd = listOfNames.Where(x => predicate(x, criteria)).ToList();

                    foreach (var name in guestToAdd)
                    {
                        int index = listOfNames.IndexOf(name);
                        listOfNames.Insert(index + 1, name);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(listOfNames.Any()? 
                    $"{string.Join(", ", listOfNames)} are going to the party!" :
                    $"Nobody is going to the party!");
        }

        static Func<string, string, bool> GetFunc(string filterCommand)
        {
            if (filterCommand == "StartsWith")
            {
                return (x, c) => x.StartsWith(c);
            }
            else if (filterCommand == "EndsWith")
            {
                return (x, c) => x.EndsWith(c);
            }
            else if (filterCommand == "Length")
            {
                return (x, c) => x.Length == int.Parse(c);
            }

            return null;
        }
    }
}
