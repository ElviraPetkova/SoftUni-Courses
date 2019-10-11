using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfStrings = Console.ReadLine().Split().ToArray();

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                string word = arrayOfStrings[i].ToLower();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 0);
                }

                dictionary[word]++;
                
            }

            var result = dictionary.Where(x => x.Value % 2 != 0).ToList();

            foreach (var kvp in result)
            {
                Console.Write(kvp.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
