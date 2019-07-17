using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Queue<int[]> petrolPlumps = new Queue<int[]>();

            for (int i = 0; i < counter; i++)
            {
                int[] petrolPlump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPlumps.Enqueue(petrolPlump);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var petrol in petrolPlumps)
                {
                    int petrolAmount = petrol[0];
                    int distance = petrol[1];

                    totalFuel += petrolAmount - distance;

                    if(totalFuel < 0)
                    {
                        petrolPlumps.Enqueue(petrolPlumps.Dequeue());
                        index++;
                        break;
                    }
                }

                if(totalFuel >= 0)
                {
                    break;
                }

            }

            Console.WriteLine(index);
        }
    }
}
