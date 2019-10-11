using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            foreach (var word in keyWords)
            {
                while (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
