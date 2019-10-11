using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();

            List<char> charactersBetwenTwo = CharactersBetwenTwo(firstCharacter, secondCharacter, randomString);

            int sumOfThisCharacters = SumOfAsciiCode(charactersBetwenTwo);

            Console.WriteLine(sumOfThisCharacters);
        }

        private static int SumOfAsciiCode(List<char> charactersBetwenTwo)
        {
            int sum = 0;

            foreach (char item in charactersBetwenTwo)
            {
                sum += item;
            }

            return sum;
        }

        private static List<char> CharactersBetwenTwo(char firstCharacter, char secondCharacter, string randomString)
        {
            List<char> charactersBetwenTwo = new List<char>();

            int maxChar = Math.Max(firstCharacter, secondCharacter);
            int minChar = Math.Min(firstCharacter, secondCharacter);

            for (int i = 0; i < randomString.Length; i++)
            {
                if(randomString[i] > minChar && randomString[i] < maxChar)
                {
                    charactersBetwenTwo.Add(randomString[i]);
                }
            }

            return charactersBetwenTwo;
        }
    }
}
