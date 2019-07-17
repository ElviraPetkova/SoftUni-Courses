using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<double>>();

            for (int i = 0; i < counter; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if(dictionary.ContainsKey(name) == false)
                {
                    dictionary.Add(name, new List<double>());
                }

                dictionary[name].Add(grade);
            }

            foreach (var kvp in dictionary)
            {
                Console.Write($"{kvp.Key} -> ");
                foreach (var value in kvp.Value)
                {
                    Console.Write($"{value:f2} ");
                }
                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
