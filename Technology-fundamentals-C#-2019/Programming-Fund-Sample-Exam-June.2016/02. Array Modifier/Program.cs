using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    Console.WriteLine(string.Join(", ", arrayOfNumbers));
                    break;
                }

                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    SwapingTwoElements(arrayOfNumbers, firstIndex, secondIndex);
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    MultiplyTwoElementsAndSaveInFirstIndex(arrayOfNumbers, firstIndex, secondIndex);
                }
                else if (command == "decrease")
                {
                    DecreaseAllElements(arrayOfNumbers);
                }
            }
        }

        private static void DecreaseAllElements(long[] arrayOfNumbers)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i]--;
            }
        }

        private static void MultiplyTwoElementsAndSaveInFirstIndex(long[] arrayOfNumbers, int firstIndex, int secondIndex)
        {
            long firstValue = arrayOfNumbers[firstIndex];
            long secondValue = arrayOfNumbers[secondIndex];

            arrayOfNumbers[firstIndex] = firstValue * secondValue;
        }

        private static void SwapingTwoElements(long[] arrayOfNumbers, int firstIndex, int secondIndex)
        {
            long firstValue = arrayOfNumbers[firstIndex];
            long secondValue = arrayOfNumbers[secondIndex];

            arrayOfNumbers[firstIndex] = secondValue;
            arrayOfNumbers[secondIndex] = firstValue;
        }
    }
}
