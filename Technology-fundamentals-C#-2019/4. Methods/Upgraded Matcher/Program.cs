using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgraded_Matcher
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split().ToArray();
            long[] guantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            int lenghtOfGuantity = guantity.Length - 1; //1?

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }

                string[] action = input.Split().ToArray();
                string product = action[0];
                long guant = long.Parse(action[1]);

                int index = Array.IndexOf(nameOfProducts, product);

                if(index > lenghtOfGuantity)
                {
                    Console.WriteLine($"We do not have enough {product}");
                    continue;
                }

                long guantOfArr = guantity[index];

                if(guant > guantOfArr && guant > 0)
                {
                    Console.WriteLine($"We do not have enough {product}");
                    continue;
                }

                decimal price = guant * prices[index];
                guantity[index] -= guant;

                Console.WriteLine($"{nameOfProducts[index]} x {guant} costs {price:f2}");

            }
        }
    }
}
