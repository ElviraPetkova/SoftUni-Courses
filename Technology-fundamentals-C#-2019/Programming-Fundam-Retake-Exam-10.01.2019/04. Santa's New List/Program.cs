using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var childrens = new Dictionary<string, int>();
            var presents = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] tokens = input.Split("->");

                if(tokens[0] == "Remove")
                {
                    //Removethis child
                    if (childrens.ContainsKey(tokens[1]))
                    {
                        childrens.Remove(tokens[1]);
                    }
                }
                else
                {
                    string kidsName = tokens[0];
                    string present = tokens[1];
                    int count = int.Parse(tokens[2]);

                    if(childrens.ContainsKey(kidsName) == false)
                    {
                        childrens.Add(kidsName, 0);
                    }

                    if(presents.ContainsKey(present) == false)
                    {
                        presents.Add(present, 0);
                    }

                    childrens[kidsName] += count;
                    presents[present] += count;
                }
            }

            var resultChildrens = childrens.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

            Console.WriteLine("Children:");
            foreach (var kvp in resultChildrens)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (var kvp in presents)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
