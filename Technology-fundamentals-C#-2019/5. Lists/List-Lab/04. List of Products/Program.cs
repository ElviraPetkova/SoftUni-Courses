using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string product = Console.ReadLine();
                listOfProducts.Add(product);
            }

            var resultList = listOfProducts.OrderBy(x => x).ToList();

            for (int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{resultList[i]}");
            }
        }
    }
}
