using System;
using System.Collections.Generic;
using System.Linq;

namespace _003._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, double>>();
            //key=shopName, key=productName, value=price

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Revision")
                {
                    break;
                }

                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if(dictionary.ContainsKey(shop) == false)
                {
                    dictionary.Add(shop, new Dictionary<string, double>());
                }

                //if(dictionary[shop].ContainsKey(product) == false)
                //{
                //    dictionary[shop].Add(product, price);
                //}

                dictionary[shop][product] = price;
            }

            foreach (var kvp in dictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
