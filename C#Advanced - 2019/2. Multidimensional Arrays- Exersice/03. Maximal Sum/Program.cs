using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arrayRow = info[0];
            int arrayCol = info[1];

            int[,] array = new int[arrayRow, arrayCol];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                int[] characters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = characters[col];
                }
            }

            int maxSum = int.MinValue;
            int indexRow = -1;
            int indexCol = -1;

            for (int row = 0; row < array.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 2; col++)
                {
                    int currentSum = array[row, col] + array[row, col + 1] + array[row, col + 2]
                        + array[row + 1, col] + array[row + 1, col + 1] + array[row + 1, col + 2]
                        + array[row + 2, col] + array[row + 2, col + 1] + array[row + 2, col + 2];

                    if(maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{array[indexRow, indexCol]} {array[indexRow, indexCol + 1]} {array[indexRow, indexCol + 2]}");
            Console.WriteLine($"{array[indexRow + 1, indexCol]} {array[indexRow + 1, indexCol + 1]} " +
                $"{array[indexRow + 1, indexCol + 2]}");
            Console.WriteLine($"{array[indexRow + 2, indexCol]} {array[indexRow + 2, indexCol + 1]} " +
                $"{array[indexRow + 2, indexCol + 2]}");
        }
    }
}
