using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                if(tokens[0] == "Add")
                {
                    int count = int.Parse(tokens[1]);

                    wagons.Add(count);
                }
                else
                {
                    int count = int.Parse(tokens[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int numberOfPassagers = wagons[i];

                        if (numberOfPassagers + count > maxCapacity)
                        {
                            continue;
                        }
                        else
                        {
                            wagons[i] = numberOfPassagers + count;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
