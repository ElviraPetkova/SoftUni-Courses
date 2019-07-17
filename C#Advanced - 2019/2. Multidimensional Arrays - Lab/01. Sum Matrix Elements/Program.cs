using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = dim[0];
            int col = dim[1];

            int[,] array = new int[row, col];

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sum += numbers.Sum();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = numbers[j];
                }
            }

            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
