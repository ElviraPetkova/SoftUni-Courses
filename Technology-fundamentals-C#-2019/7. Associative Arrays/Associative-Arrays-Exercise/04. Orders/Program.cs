using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsAndPrices = new Dictionary<string, decimal>();
            var productsAndQuantity = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "buy")
                {
                    break;
                }

                string[] info = input.Split();

                string product = info[0];
                decimal price = decimal.Parse(info[1]);
                int quantity = int.Parse(info[2]);

                if (!productsAndPrices.ContainsKey(product))
                {
                    productsAndPrices.Add(product, price);
                    productsAndQuantity.Add(product, quantity);
                }
                else
                {
                    productsAndPrices[product] = price;
                    productsAndQuantity[product] += quantity;
                }
            }

            foreach (var kvp in productsAndPrices)
            {
                string product = kvp.Key;
                decimal price = kvp.Value * productsAndQuantity[product];

                Console.WriteLine($"{product} -> {price}");
            }
        }
    }
}
