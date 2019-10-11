using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeAndItems = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END" || input == "End")
                {
                    break;
                }

                var tokens = input.Split("->");

                string command = tokens[0];
                string store = tokens[1];

                if(command == "Add")
                {
                    if(tokens[2].Contains(',') == false)
                    {
                        string item = tokens[2];

                        if(storeAndItems.ContainsKey(store) == false)
                        {
                            storeAndItems.Add(store, new List<string>());
                            
                        }

                        storeAndItems[store].Add(item);
                       
                    }
                    else
                    {
                        var items = tokens[2].Split(',');
                        if (storeAndItems.ContainsKey(store) == false)
                        {
                            storeAndItems.Add(store, new List<string>());
                            
                        }
                        storeAndItems[store].AddRange(items);
                    }
                }
                else if(command == "Remove")
                {
                    if (storeAndItems.ContainsKey(store))
                    {
                        storeAndItems.Remove(store);
                    }
                }
            }

            Console.WriteLine("Stores list:");

            foreach (var kvp in storeAndItems.OrderByDescending(x=>x.Value.Count()).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                if(kvp.Value.Count() == 0)
                {
                    continue;
                }
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
