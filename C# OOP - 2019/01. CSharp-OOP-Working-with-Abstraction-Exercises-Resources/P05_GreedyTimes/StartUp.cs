using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            long capacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Bag bag = new Bag(capacity);

            for (int i = 0; i < safe.Length; i+=2)
            {
                string key = safe[i];
                int value = int.Parse(safe[i + 1]);

                InsertItem(bag, key, value);
            }

            Console.WriteLine(bag.ToString());
        }

        private static void InsertItem(Bag bag, string key, int value)
        {
            if(key.Length == 3)
            {
                Cash cash = new Cash(key, value);
                bag.AddCashItem(cash);
            }
            else if(key.Length >= 4 && key.ToLower().EndsWith("gem"))
            {
                Gem gem = new Gem(key, value);
                bag.AddGemItem(gem);
            }
            else if (key.ToLower().Equals("gold"))
            {
                Gold gold = new Gold(key, value);
                bag.AddGoldItem(gold);
            }
        }
    }
}