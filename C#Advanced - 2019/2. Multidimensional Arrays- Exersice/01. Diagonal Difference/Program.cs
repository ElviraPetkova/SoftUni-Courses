using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] array = new int[size, size];

            int firstSum = 0;
            int index = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = numbers[col];
                }

                firstSum += array[row, index];
                index++;
            }

            index = size - 1;
            int secondSum = 0;

            for (int row = 0; row < size; row++)
            {
                secondSum += array[row, index];
                index--;
            }

            int diff = Math.Abs(firstSum - secondSum);
            Console.WriteLine(diff);

        }
    }
}
