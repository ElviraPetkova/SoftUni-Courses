using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Heists
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int priceOfJewels = numbers[0];
            int priceOfGold = numbers[1];

            int profit = 0;
            int totalCost = 0;
            
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Jail Time")
                {
                    if(profit >= totalCost)
                    {
                        Console.WriteLine($"Heists will continue. Total earnings: {profit - totalCost}.");
                    }
                    else
                    {
                        Console.WriteLine($"Have to find another job. Lost: {totalCost - profit}.");
                    }
                    break;
                }

                string[] actions = input.Split().ToArray();
                string act = actions[0];
                int cost = int.Parse(actions[1]);
                totalCost += cost;

                for (int i = 0; i < act.Length; i++)
                {
                    if(act[i] == '%')
                    {
                        profit += priceOfJewels;
                    }

                    if(act[i] == '$')
                    {
                        profit += priceOfGold;
                    }
                }
            }
        }
    }
}
