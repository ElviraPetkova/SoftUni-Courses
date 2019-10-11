using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            int sumOfNumbersOfCharacters = 0;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sumOfNumbersOfCharacters += (int)character;
            }

            Console.WriteLine($"The sum equals: {sumOfNumbersOfCharacters}");
        }
    }
}
