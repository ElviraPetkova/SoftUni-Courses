using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char[] charsOfWord = text[i].ToCharArray();

                for (int j = 0; j < charsOfWord.Length; j++)
                {
                    char oneChar = charsOfWord[j];

                    if(dictionary.ContainsKey(oneChar) == false)
                    {
                        dictionary.Add(oneChar, 0);
                    }

                    dictionary[oneChar]++;
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
