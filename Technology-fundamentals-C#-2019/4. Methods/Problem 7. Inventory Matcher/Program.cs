using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Inventory_Matcher
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split().ToArray();
            long[] guantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while(true)
            {
                string input = Console.ReadLine();
                if(input == "done")
                {
                    break;
                }

                int index = Array.IndexOf(nameOfProducts, input);

                Console.WriteLine($"{nameOfProducts[index]} costs: {prices[index]}; Available quantity: {guantity[index]}");
            }
        }
    }
}
