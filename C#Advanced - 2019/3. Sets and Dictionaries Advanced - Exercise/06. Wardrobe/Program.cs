using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var wardrobeFromClothers = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(wardrobeFromClothers.ContainsKey(color) == false)
                {
                    wardrobeFromClothers.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (wardrobeFromClothers[color].ContainsKey(clothes[j]) == false)
                    {
                        wardrobeFromClothers[color].Add(clothes[j], 0);
                    }

                    wardrobeFromClothers[color][clothes[j]]++;
                }
            }

            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string colorClother = tokens[0];
            string searhClother = tokens[1];
            bool isFound = false;

            if (wardrobeFromClothers.ContainsKey(colorClother))
            {
                if (wardrobeFromClothers[colorClother].ContainsKey(searhClother))
                {
                    isFound = true;
                }
            }

            foreach (var kvp in wardrobeFromClothers)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clot in kvp.Value)
                {
                    if(kvp.Key == colorClother && clot.Key == searhClother && isFound)
                    {
                        Console.WriteLine($"* {clot.Key} - {clot.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clot.Key} - {clot.Value} ");
                    }
                }
            }

        }
    }
}
