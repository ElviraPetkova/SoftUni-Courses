using System;

namespace _3.Characters_in_Range
{
    class Program
    {
        public static void Main(string[] args)
        {
            char firtChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharactersInRange(firtChar, secondChar);
        }

        public static void PrintCharactersInRange(char firstChar, char secondChar)
        {
            string characters = string.Empty;

            int maxChar = Math.Max(firstChar, secondChar);
            int minChar = Math.Min(firstChar, secondChar);

            for (char i = (char)minChar; i < (char)maxChar; i++)
            {
                if(i == minChar)
                {
                    continue;
                }
                characters += i + " ";
            }

            Console.WriteLine(characters);
        }
    }
}
