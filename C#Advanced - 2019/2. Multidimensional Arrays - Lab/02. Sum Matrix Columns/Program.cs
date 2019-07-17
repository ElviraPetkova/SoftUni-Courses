using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arrayRow = dim[0];
            int arrayCol = dim[1];

            int[,] array = new int[arrayRow, arrayCol];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = numbers[j];
                }
            }

            
            for (int col = 0; col < array.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    sum += array[row, col];
                }

                Console.WriteLine(sum);

            }
            
        }
    }
}
