using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Tra
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textInMorseAplhabet = Console.ReadLine()
                .Split(" | ")
                .ToArray();

            StringBuilder textInEnglishAplhabet = ReturnTextInEnglishAplhabet(textInMorseAplhabet);
            Console.WriteLine(textInEnglishAplhabet);
        }

        private static StringBuilder ReturnTextInEnglishAplhabet(string[] textInMorseAplhabet)
        {
            Dictionary<char, string> morseAlphabet = ReturnMorseAlphabet();

            StringBuilder textInEnglish = new StringBuilder();

            for (int i = 0; i < textInMorseAplhabet.Length; i++)
            {
                string[] currentString = textInMorseAplhabet[i].Split(' ');
                for (int j = 0; j < currentString.Length; j++)
                {
                    string oneStringInMorseAplhabet = currentString[j];
                    if (morseAlphabet.ContainsValue(oneStringInMorseAplhabet))
                    {
                        char needChar = ChekingMorseAplhabet(oneStringInMorseAplhabet, morseAlphabet);
                        textInEnglish.Append(needChar);
                    }
                }

                textInEnglish.Append(' ');
            }

            return textInEnglish;
        }

        private static char ChekingMorseAplhabet(string oneStringInMorseAplhabet, Dictionary<char, string> morseAlphabet)
        {
            char oneCharacter = ' ';

            foreach (var kvp in morseAlphabet)
            {
                if(kvp.Value == oneStringInMorseAplhabet)
                {
                    oneCharacter = kvp.Key;
                }
            }

            return oneCharacter;
        }

        private static Dictionary<char, string> ReturnMorseAlphabet()
        {
            Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
            {
                {'A', ".-" },
                {'B', "-..." },
                {'C', "-.-." },
                {'D', "-.." },
                {'E', "." },
                {'F', "..-." },
                {'G', "--." },
                {'H', "...." },
                {'I', ".." },
                {'J', ".---" },
                {'K', "-.-" },
                {'L', ".-.." },
                {'M', "--" },
                {'N', "-." },
                {'O', "---" },
                {'P', ".--." },
                {'Q', "--.-" },
                {'R', ".-." },
                {'S', "..." },
                {'T', "-" },
                {'U', "..-" },
                {'V', "...-" },
                {'W', ".--" },
                {'X', "-..-" },
                {'Y', "-.--" },
                {'Z', "--.." }
            };

            return morseAlphabet;
        }
    }
}
