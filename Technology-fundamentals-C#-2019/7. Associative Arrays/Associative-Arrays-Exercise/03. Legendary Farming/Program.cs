using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            var junk = new Dictionary<string, int>();

            string winn = string.Empty;
            bool haveWinn = false;

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                for (int i = 0; i < input.Length; i+= 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if(material == "shards" || material == "fragments" || material == "motes")
                    {
                        materials[material] += quantity;

                        if(materials[material] >= 250)
                        {
                            materials[material] -= 250;

                            switch (material)
                            {
                                case "shards": winn = "Shadowmourne"; break;
                                case "fragments": winn = "Valanyr"; break;
                                case "motes": winn = "Dragonwrath"; break;
                            }

                            Console.WriteLine($"{winn} obtained!");
                            haveWinn = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }

                        junk[material] += quantity;
                    }
                }

                if (haveWinn)
                {
                    break;
                }
            }

            var resultMaterials = materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            var resultJunk = junk.OrderBy(x => x.Key).ToList();

            foreach (var kvp in resultMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in resultJunk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
