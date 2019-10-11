using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, List<string>>(); //key = nameOfCompany, value = list of id

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] info = input.Split(" -> ");
                string company = info[0];
                string employeeId = info[1];

                if(dictionary.ContainsKey(company) == false)
                {
                    dictionary.Add(company, new List<string>());
                    dictionary[company].Add(employeeId);
                }
                else
                {
                    if(dictionary[company].Contains(employeeId) == false)
                    {
                        dictionary[company].Add(employeeId);
                    }
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);

                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
