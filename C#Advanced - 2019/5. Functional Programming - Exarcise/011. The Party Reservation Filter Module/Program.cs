using System;
using System.Collections.Generic;
using System.Linq;

namespace _011._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            List<string> filters = new List<string>();

            while (command != "Print")
            {
                //Add filter;Starts with;P
                string[] info = command.Split(";");
                string typeCommand = info[0];
                string filter = info[1];
                string criteria = info[2];

                if(typeCommand == "Add filter")
                {
                    filters.Add($"{filter};{criteria}");
                }
                else if(typeCommand == "Remove filter")
                {
                    filters.Remove($"{filter};{criteria}");
                }

                command = Console.ReadLine();
            }

            //List<string> guestToAdd = new List<string>();

            foreach (var item in filters)
            {
                var tokens = item.Split(";");
                string filter = tokens[0];
                string criteria = tokens[1];

                Func<string, string, bool> predicate = GetFunc(filter);

                guests = guests.Where(x => !predicate(x, criteria)).ToList();
            }

            Console.WriteLine(string.Join(" ", guests));

        }

        static Func<string, string, bool> GetFunc(string filterCommand)
        {
            if (filterCommand == "Starts with")
            {
                return (x, c) => x.StartsWith(c);
            }
            else if (filterCommand == "Ends with")
            {
                return (x, c) => x.EndsWith(c);
            }
            else if (filterCommand == "Length")
            {
                return (x, c) => x.Length == int.Parse(c);
            }
            else if(filterCommand == "Contains")
            {
                return (x, c) => x.Contains(c);
            }

            return null;
        }
    }
}
