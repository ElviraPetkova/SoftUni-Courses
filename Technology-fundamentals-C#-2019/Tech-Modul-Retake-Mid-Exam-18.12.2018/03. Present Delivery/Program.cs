using System;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            int position = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Merry Xmas!")
                {
                    break;
                }

                string[] info = input.Split();

                int lenght = int.Parse(info[1]);

                if(position + lenght > houses.Length - 1)
                {
                    position = (position + lenght) % houses.Length;
                }
                else
                {
                    position += lenght;
                }
                

                if (houses[position] <= 0)
                {
                    Console.WriteLine($"House {position} will have a Merry Christmas.");
                }

                houses[position] -= 2;
                
            }

            var worryHouses = houses.Where(x => x > 0).ToList();

            Console.WriteLine($"Santa's last position was {position}.");

            if (worryHouses.Count > 0)
            {
                Console.WriteLine($"Santa has failed {worryHouses.Count} houses.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
