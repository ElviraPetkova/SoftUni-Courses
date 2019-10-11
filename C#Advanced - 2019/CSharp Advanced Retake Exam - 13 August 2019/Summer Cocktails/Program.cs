using System;
using System.Collections.Generic;
using System.Linq;

namespace Summer_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> baskets = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            SortedDictionary<string, int> givenCocteils = new SortedDictionary<string, int>
            {
                ["Mimosa"] = 150,
                ["Daiquiri"] = 250,
                ["Sunshine"] = 300,
                ["Mojito"] = 400
            };

            SortedDictionary<string, int> cocteils = new SortedDictionary<string, int>
            {
                ["Mimosa"] = 0,
                ["Daiquiri"] = 0,
                ["Sunshine"] = 0,
                ["Mojito"] = 0
            };

            while (baskets.Any() && freshness.Any())
            {
                if(baskets.Peek() == 0)
                {
                    baskets.Dequeue();
                    continue;
                }

                int basket = baskets.Dequeue();
                int freshnes = freshness.Pop();

                int product = basket * freshnes;

                if (givenCocteils.ContainsValue(product))
                {
                    string currentCocteil = givenCocteils.FirstOrDefault(x => x.Value == product).Key;
                    
                    cocteils[currentCocteil]++;
                }
                else
                {
                    basket += 5;
                    baskets.Enqueue(basket);
                }
            }

            var currentCocteils = cocteils.Where(x => x.Value == 0).ToList();
            if(currentCocteils.Any())
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }
            else
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }

            if (baskets.Any())
            {
                Console.WriteLine($"Ingredients left: {baskets.Sum()}");
            }

            foreach (var kvp in cocteils.Where(x => x.Value > 0))
            {
                Console.WriteLine($" # {kvp.Key} --> {kvp.Value}");
            }
        }
    }
}
