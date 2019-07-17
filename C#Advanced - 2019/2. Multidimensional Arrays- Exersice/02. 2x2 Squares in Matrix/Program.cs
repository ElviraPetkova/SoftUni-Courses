using System;
using System.Linq;

namespace _02._2x2_Squares_in_Matrix
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

            char[,] array = new char[arrayRow, arrayCol];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                char[] characters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = characters[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 1; col++)
                {
                    if(array[row, col] == array[row, col + 1]
                        && array[row, col] == array[row + 1, col]
                        && array[row, col] == array[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
