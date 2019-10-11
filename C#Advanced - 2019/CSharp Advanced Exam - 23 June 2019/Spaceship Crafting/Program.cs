using System;
using System.Collections.Generic;
using System.Linq;

namespace Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> advancedMaterials = new Dictionary<string, int>()
            {
                ["Glass"] = 25,
                ["Aluminium"] = 50,
                ["Lithium"] = 75,
                ["Carbon fiber"] = 100
            };

            Queue<int> chemicalLiquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> physicalItems = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            SortedDictionary<string, int> materials = new SortedDictionary<string, int>
            {
                ["Glass"] = 0,
                ["Aluminium"] = 0,
                ["Lithium"] = 0,
                ["Carbon fiber"] = 0
            };

            while (chemicalLiquids.Any() && physicalItems.Any())
            {
                int liquid = chemicalLiquids.Dequeue();
                int item = physicalItems.Pop();

                int sum = liquid + item;

                if (advancedMaterials.ContainsValue(sum))
                {
                    string currentMaterial = advancedMaterials.FirstOrDefault(x => x.Value == sum).Key;
                    materials[currentMaterial]++;
                }
                else
                {
                    item += 3;
                    physicalItems.Push(item);
                }
            }

            var matetialsWithoutValue = materials.Where(x => x.Value == 0).ToList();
            if(matetialsWithoutValue.Any())
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            else
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }

            if (chemicalLiquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (physicalItems.Any())
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
