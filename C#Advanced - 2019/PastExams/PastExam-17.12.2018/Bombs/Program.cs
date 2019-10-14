namespace Bombs
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[][] matrix = new int[sizeOfMatrix][];

            CompleteMatrix(matrix);

            string[] informationByAllBombs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < informationByAllBombs.Length; i++)
            {
                int[] coordinationByBomb = informationByAllBombs[i]
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                int rowByBomb = coordinationByBomb[0];
                int colByBomb = coordinationByBomb[1];

                if (!ValidationBombCoordination(matrix, rowByBomb, colByBomb))
                {
                    continue;
                }

                if(matrix[rowByBomb][colByBomb] <= 0)
                {
                    continue;
                }

                ExplodeBomb(matrix, rowByBomb,colByBomb);

            }

            int countByAliveCells = GetAliveCellsCount(matrix);
            int sumOfAliveCells = GetSumOfAliveCells(matrix);

            Print(countByAliveCells, sumOfAliveCells, matrix);
        }

        private static void Print(int countByAliveCells, int sumOfAliveCells, int[][] matrix)
        {
            Console.WriteLine($"Alive cells: {countByAliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static int GetSumOfAliveCells(int[][] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row].Where(x => x > 0).Sum();
            }

            return sum;
        }

        private static int GetAliveCellsCount(int[][] matrix)
        {
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                counter += matrix[row].Where(x => x > 0).Count();
            }

            return counter;
        }

        private static void ExplodeBomb(int[][] matrix, int row, int col)
        {
            ExploadeUp(matrix, row, col);

            ExploadeMiddle(matrix, row, col);

            ExploadeDown(matrix, row, col);

            matrix[row][col] = 0;
        }

        private static void ExploadeDown(int[][] matrix, int row, int col)
        {
            int bomb = matrix[row][col];

            if (row + 1 < matrix.GetLength(0))
            {
                if (matrix[row + 1][col] > 0)
                {
                    matrix[row + 1][col] -= bomb;
                }

                if (col - 1 >= 0 && matrix[row + 1][col - 1] > 0)
                {
                    matrix[row + 1][col - 1] -= bomb;
                }

                if (col + 1 < matrix[row + 1].Length && matrix[row + 1][col + 1] > 0)
                {
                    matrix[row + 1][col + 1] -= bomb;
                }
            }
        }

        private static void ExploadeMiddle(int[][] matrix, int row, int col)
        {
            int bomb = matrix[row][col];
            if (col - 1 >= 0 && matrix[row][col - 1] > 0)
            {
                matrix[row][col - 1] -= bomb;
            }

            if (col + 1 < matrix[row].Length && matrix[row][col + 1] > 0)
            {
                matrix[row][col + 1] -= bomb;
            }
        }

        private static void ExploadeUp(int[][] matrix, int row, int col)
        {
            int bomb = matrix[row][col];
            if (row - 1 >= 0)
            {
                if (matrix[row - 1][col] > 0)
                {
                    matrix[row - 1][col] -= bomb;
                }

                if (col - 1 >= 0 && matrix[row - 1][col - 1] > 0)
                {
                    matrix[row - 1][col - 1] -= bomb;
                }

                if (col + 1 < matrix[row - 1].Length && matrix[row - 1][col + 1] > 0)
                {
                    matrix[row - 1][col + 1] -= bomb;
                }
            }
        }

        private static bool ValidationBombCoordination(int[][] matrix, int row, int col)
            => row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length ? true : false;

        private static void CompleteMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}
