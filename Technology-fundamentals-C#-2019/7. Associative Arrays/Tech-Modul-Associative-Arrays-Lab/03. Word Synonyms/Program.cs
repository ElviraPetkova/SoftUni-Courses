using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<string>>(); //key = word, list<string> - value = synonyms

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if(dictionary.ContainsKey(word) == false)
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(synonym);
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
