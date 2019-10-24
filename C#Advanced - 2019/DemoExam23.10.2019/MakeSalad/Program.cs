namespace MakeSalad
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Vegetable
    {
        public Vegetable(string name, int calories)
        {
            this.Name = name;
            this.Calories = calories;
        }

        public string Name { get; set; }

        public int Calories { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Vegetable> products = new List<Vegetable>
            {
                new Vegetable("tomato", 80),
                new Vegetable("carrot", 136),
                new Vegetable("lettuce", 109),
                new Vegetable("potato", 215)
            };

            string[] inputOfVegetables = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] inputOfSalad = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<string> vegetables = new Queue<string>(inputOfVegetables);
            Stack<int> salads = new Stack<int>(inputOfSalad);

            List<int> finishSalads = new List<int>();

            int leftCalories = 0;

            while (vegetables.Any() && salads.Any())
            {
                string oneVegetable = vegetables.Dequeue();
                int oneSalad = salads.Peek();

                Vegetable product = products.FirstOrDefault(p => p.Name == oneVegetable);
                if(product == null)
                {
                    continue;
                }

                int calories = product.Calories;

                if(leftCalories == 0)
                {
                    leftCalories = oneSalad - calories;
                    if(calories >= oneSalad)
                    {
                        finishSalads.Add(oneSalad);
                        salads.Pop();
                        leftCalories = 0;
                    }
                }
                else
                {
                    if(calories >= leftCalories)
                    {
                        finishSalads.Add(oneSalad);
                        salads.Pop();
                        leftCalories = 0;
                    }
                    else
                    {
                        leftCalories = leftCalories - calories;
                    }
                }                
            }

            if(leftCalories > 0 && salads.Any())
            {
                finishSalads.Add(salads.Pop());
            }

            Console.WriteLine(string.Join(" ", finishSalads));

            if(vegetables.Any())
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
            else if(salads.Any())
            {
                Console.WriteLine(string.Join(" ", salads));
            }

        }
    }
}
