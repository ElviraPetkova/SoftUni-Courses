using System;
using System.Linq;

namespace _05._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arrayRow = input[0];
            int arrayCol = input[1];

            int[,] array = new int[arrayRow, arrayCol];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = numbers[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 1; col++)
                {
                    int sum = array[row, col] + array[row, col + 1] +
                        array[row + 1, col] + array[row + 1, col + 1]; 

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }

            Console.WriteLine($"{array[selectedRow, selectedCol]} {array[selectedRow, selectedCol + 1]}");
            Console.WriteLine($"{array[selectedRow + 1, selectedCol]} {array[selectedRow + 1, selectedCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
