using System;
using System.Collections.Generic;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsByServes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queuFromCarsByServes = new Queue<string>(carsByServes);
            Stack<string> stackByHistory = new Stack<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {

                    break;
                }

                var tokens = input.Split("-"); 

                string command = tokens[0];

                if(command == "Service")
                {
                    if(queuFromCarsByServes.Count == 0)
                    {
                        continue;
                    }

                    string car = queuFromCarsByServes.Dequeue();
                    stackByHistory.Push(car);
                    Console.WriteLine($"Vehicle {car} got served.");
                }
                else if (command == "CarInfo")
                {
                    string car = tokens[1];
                    if (queuFromCarsByServes.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", stackByHistory));
                }
            }

            if(queuFromCarsByServes.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queuFromCarsByServes)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", stackByHistory)}");
        }
    }
}
