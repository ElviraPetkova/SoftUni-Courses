using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var parking = new Dictionary<string, string>(); //key = name, value = license

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string userName = input[1];

                if(command == "register")
                {
                    string license = input[2];

                    if (parking.ContainsKey(userName) == false)
                    {
                        parking.Add(userName, license);
                        Console.WriteLine($"{userName} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else if(command == "unregister")
                {
                    if (parking.ContainsKey(userName))
                    {
                        parking.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach (var kvp in parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
