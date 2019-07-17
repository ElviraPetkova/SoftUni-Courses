using System;
using System.Linq;

namespace _06._Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int matrixRow = size[0];
            int matrixCol = size[1];

            int[][] matrix = new int[matrixRow][];

            for (int row = 0; row < matrixRow; row++)
            {
                matrix[row] = new int[matrixCol];
            }

            int[] bomb = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int radius = bomb[2];

            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) +
                       Math.Pow(col - bombCol, 2));

                    if(distance <= radius)
                    {
                        matrix[row][col] = 1;
                    }

                }
            }

            int[][] secondMatrix = new int[matrixCol][];

            for (int row = 0; row < matrixCol; row++)
            {
                secondMatrix[row] = new int[matrixRow];

                for (int col = 0; col < matrixRow; col++)
                {
                    secondMatrix[row][col] = matrix[col][row];
                }

                secondMatrix[row] = secondMatrix[row].OrderByDescending(x => x).ToArray();
            }

            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row][col] = secondMatrix[col][row];
                }

            }

            Console
               .WriteLine(String
               .Join(Environment.NewLine, matrix
               .Select(r => String.Join("", r))));
        }
    }
}
