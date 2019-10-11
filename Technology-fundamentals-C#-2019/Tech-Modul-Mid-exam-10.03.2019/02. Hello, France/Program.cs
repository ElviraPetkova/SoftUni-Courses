using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collections = Console.ReadLine()
                .Split('|')
                .ToArray();

            double budjet = double.Parse(Console.ReadLine());
            List<double> buyItems = new List<double>();

            double profit = 0;

            for (int i = 0; i < collections.Length; i++)
            {
                string[] itemsAndPrice = collections[i].Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string item = itemsAndPrice[0];
                double price = double.Parse(itemsAndPrice[1]);

                if (item == "Clothes")
                {
                    if (price > 50.00)
                    {
                        continue;
                    }
                }
                else if (item == "Shoes")
                {
                    if(price > 35.00)
                    {
                        continue;
                    }
                }
                else if (item == "Accessories")
                {
                    if(price > 20.50)
                    {
                        continue;
                    }
                }

                if(budjet >= price)
                {
                    budjet -= price;

                    double currentPrice = price + (price * 0.4);
                    buyItems.Add(currentPrice);

                    switch (item)
                    {
                        case "Clothes": profit += currentPrice - price; break;
                        case "Shoes": profit += currentPrice - price; break;
                        case "Accessories": profit += currentPrice - price; break;
                    }
                }
                else
                {
                    continue;
                }
            }

            for (int i = 0; i < buyItems.Count; i++)
            {
                Console.Write($"{buyItems[i]:f2} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:f2}");

            budjet += buyItems.Sum();

            if (budjet >= 150.00)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
