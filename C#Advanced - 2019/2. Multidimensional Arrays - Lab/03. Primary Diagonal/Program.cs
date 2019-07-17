using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] array = new int[size, size];

            int sum = 0;
            int index = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = numbers[col];
                }

                sum += array[row, index];
                index++;
            }
            
            Console.WriteLine(sum);
        }
    }
}
