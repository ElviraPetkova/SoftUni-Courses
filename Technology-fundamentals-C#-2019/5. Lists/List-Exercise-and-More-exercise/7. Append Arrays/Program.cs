using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfArrays = Console.ReadLine()
                .Split('|')
                .ToList();

            List<string> resultList = new List<string>();

            for (int i = listOfArrays.Count - 1; i >= 0; i--)
            {
                string currentList = listOfArrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToString();
                resultList.Add(currentList);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
