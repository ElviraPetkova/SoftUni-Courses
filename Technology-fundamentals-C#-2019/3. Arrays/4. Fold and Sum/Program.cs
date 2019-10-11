using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] leftArray = new int[numbers.Length / 4];
            int[] middleArray = new int[numbers.Length / 2];
            int[] rightArray = new int[numbers.Length / 4];

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                leftArray[i] = numbers[i];
                rightArray[i] = numbers[i + 3 * (numbers.Length) / 4];
            }

            leftArray = leftArray.Reverse().ToArray();
            rightArray = rightArray.Reverse().ToArray();

            int midd = middleArray.Length / 2;
            for (int i = 0; i < middleArray.Length; i++)
            {
                middleArray[i] = numbers[midd];
                midd++;
            }

            int[] firstArr = new int[numbers.Length / 2];
            for (int i = 0; i < leftArray.Length; i++)
            {
                firstArr[i] = leftArray[i];
            }

            for (int i = 0; i < rightArray.Length; i++)
            {
                firstArr[leftArray.Length + i] = rightArray[i];
            }

            int[] sumOfArr = new int[middleArray.Length];

            for (int b = 0; b < middleArray.Length; b++)
            {
                sumOfArr[b] = firstArr[b] + middleArray[b];
            }

            Console.WriteLine(string.Join(" ", sumOfArr));
        }
    }
}
