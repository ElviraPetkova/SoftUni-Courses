using System;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var listOfDigits = new List<char>();
            var listOfLetters = new List<char>();
            var listOfOtherCharacters = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    listOfDigits.Add(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    listOfLetters.Add(text[i]);
                }
                else
                {
                    listOfOtherCharacters.Add(text[i]);
                }
            }

            Console.WriteLine(string.Join("", listOfDigits));
            Console.WriteLine(string.Join("", listOfLetters));
            Console.WriteLine(string.Join("", listOfOtherCharacters));
        }
    }
}
