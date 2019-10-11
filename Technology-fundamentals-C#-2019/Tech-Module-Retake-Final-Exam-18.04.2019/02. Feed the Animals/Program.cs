using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Feed_the_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalsAndFoods = new Dictionary<string, int>();
            var areasAndAnimals = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Last Info")
                {
                    break;
                }

                var information = input.Split(":");
                string command = information[0];
                string animalName = information[1];
                int food = int.Parse(information[2]);
                string area = information[3];

                if(command == "Add")
                {
                    if(animalsAndFoods.ContainsKey(animalName) == false)
                    {
                        animalsAndFoods.Add(animalName, 0);
                    }

                    animalsAndFoods[animalName] += food;

                    if(areasAndAnimals.ContainsKey(area) == false)
                    {
                        areasAndAnimals.Add(area, new List<string>());
                        areasAndAnimals[area].Add(animalName);
                    }
                    else
                    {
                        if(areasAndAnimals[area].Contains(animalName) == false)
                        {
                            areasAndAnimals[area].Add(animalName);
                        }
                    }
                }
                else if(command == "Feed")
                {
                    if (animalsAndFoods.ContainsKey(animalName))
                    {
                        animalsAndFoods[animalName] -= food;

                        if(animalsAndFoods[animalName] <= 0)
                        {
                            Console.WriteLine($"{animalName} was successfully fed");
                            areasAndAnimals[area].Remove(animalName);
                        }
                    }
                }
            }

            Console.WriteLine("Animals:");
            var hungryAnimals = animalsAndFoods.Where(a => a.Value > 0).OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToList();
            foreach (var kvp in hungryAnimals)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var kvp in areasAndAnimals.OrderByDescending(a=>a.Value.Count).Where(a=>a.Value.Count > 0))
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value.Count}");
            }
            
        }
    }
}
