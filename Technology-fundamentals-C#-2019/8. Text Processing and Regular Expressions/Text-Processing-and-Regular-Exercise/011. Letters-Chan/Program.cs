using System;
using System.Linq; 

namespace _011._Letters_Chan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0M;

            foreach (var word in words)
            {
                char beforeSymbol = word[0];
                char afterSymbol = word[word.Length - 1];
                decimal number = decimal.Parse(string.Concat(word.Skip(1).Take(word.Length - 2)));

                if (char.IsUpper(beforeSymbol))
                {
                    number /= beforeSymbol - 64;
                }
                else
                {
                    number *= beforeSymbol - 96;
                }

                if (char.IsUpper(afterSymbol))
                {
                    number -= afterSymbol - 64;
                }
                else
                {
                    number += afterSymbol - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
