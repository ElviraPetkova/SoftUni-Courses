using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;

            List<string> workingDayEvents = Console.ReadLine()
                .Split('|')
                .ToList();

            bool dayFinish = true;
            for (int i = 0; i < workingDayEvents.Count; i++)
            {
                string[] info = workingDayEvents[i].Split('-');
                string eventOrIngredient = info[0];
                int number = int.Parse(info[1]);

                if(eventOrIngredient == "rest")
                {
                    if(number + energy > 100)
                    {
                        int moreEnergy = (energy + number) - 100;
                        number -= moreEnergy;
                    }

                    energy += number;

                    Console.WriteLine($"You gained {number} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if(eventOrIngredient == "order")
                {
                    if(energy >= 30) 
                    {
                        energy -= 30;
                        coins += number;

                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                }
                else
                {
                    if(coins - number > 0)
                    {
                        coins -= number;
                        Console.WriteLine($"You bought {eventOrIngredient}.");
                    }
                    else
                    {
                        dayFinish = false;
                        Console.WriteLine($"Closed! Cannot afford {eventOrIngredient}.");
                        break;
                    }
                }
            }

            if (dayFinish)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
