using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twoWords = Console.ReadLine().Split(' ');
            int sum = CharacterSumAndMultiplier(twoWords);

            Console.WriteLine(sum);
        }

        private static int CharacterSumAndMultiplier(string[] twoWords)
        {
            string firstWord = twoWords[0];
            string secondWord = twoWords[1];

            int sum = 0;
            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                int currentSum = firstWord[i] * secondWord[i];
                sum += currentSum;
            }

            string max = string.Empty;
            if (firstWord.Length > secondWord.Length)
            {
                max = firstWord;
            }
            else
            {
                max = secondWord;
            }

            for (int i = Math.Min(firstWord.Length, secondWord.Length); i < max.Length; i++)
            {
                sum += max[i];
            }

            return sum;
        }
    }
}
