using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "stop")
                {
                    break;
                }

                string resouse = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(resouse))
                {
                    dictionary.Add(resouse, 0);
                }

                dictionary[resouse] += quantity;
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
