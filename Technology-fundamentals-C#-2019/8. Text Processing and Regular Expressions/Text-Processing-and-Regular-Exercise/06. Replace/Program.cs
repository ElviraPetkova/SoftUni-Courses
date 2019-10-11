using System;

namespace _06._Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string newWord = ReplaceRepeatingChars(word);
            Console.WriteLine(newWord);
        }

        private static string ReplaceRepeatingChars(string word)
        {
            string newWord = string.Empty;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if(word[i] != word[i + 1])
                {
                    newWord += word[i];
                }
            }

            newWord += word[word.Length - 1];

            return newWord;
        }
    }
}
