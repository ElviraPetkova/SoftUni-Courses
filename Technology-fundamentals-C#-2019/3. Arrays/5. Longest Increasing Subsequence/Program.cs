using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersFromInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var finishListFromNumbers = FindLongestIncreasingSubsequence(numbersFromInput);

            Console.WriteLine(string.Join(" ", finishListFromNumbers));
        }

        static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] length = new int[sequence.Length]; //sequence.Length
            int[] prev = new int[sequence.Length];  //sequence.Length
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
