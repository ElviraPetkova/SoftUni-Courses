using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(i, input.Length);
                string firstWord = input[i];

                input[i] = input[randomIndex];
                input[randomIndex] = firstWord;
            }

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
