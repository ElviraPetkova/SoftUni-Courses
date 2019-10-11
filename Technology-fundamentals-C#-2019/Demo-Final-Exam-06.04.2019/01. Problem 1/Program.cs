using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsAndDefinition = Console.ReadLine().Split('|').ToArray();

            var dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordsAndDefinition.Length; i++)
            {
                var info = wordsAndDefinition[i].Split(':');
                string word = info[0].Trim();
                string definition = info[1].Trim();

                if(dictionary.ContainsKey(word) == false)
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(definition);
            }

            var someWords = Console.ReadLine().Split('|').ToArray();

            for (int i = 0; i < someWords.Length; i++)
            {
                string oneWord = someWords[i].Trim();

                if (dictionary.ContainsKey(oneWord))
                {
                    Console.WriteLine(oneWord);
                    foreach (var item in dictionary[oneWord].OrderByDescending(x=>x.Length))
                    {
                        Console.WriteLine($" -{item}");
                    }
                }
            }

            string command = Console.ReadLine();

            if(command == "End")
            {
                return;
            }
            else if(command == "List")
            {
                var keys = dictionary.Keys.ToList().OrderBy(x=>x);
                Console.WriteLine(string.Join(" ", keys));
            }
        }
    }
}
