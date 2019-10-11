namespace P06_Sneaking
{
    using System;
    using System.Linq;

    class Sneaking
    {
        static void Main()
        {
            int rowsCount = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rowsCount][];
            int[] samPosition = new int[2];

            FillUpMatrix(matrix, samPosition);

            string commands = Console.ReadLine();

            foreach (char move in commands)
            {
                UpdateEnemies(matrix);
                CheckingEnemies(matrix);
                MovedSam(move, matrix, samPosition);
                ChekingNikoladze(matrix);
            }

        }

        private static void ChekingNikoladze(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if(matrix[row].Contains('N') && matrix[row].Contains('S'))
                {
                    int indexNikoladze = Array.IndexOf(matrix[row], 'N');
                    matrix[row][indexNikoladze] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    PrintMatrix(matrix);
                }
            }
        }

        private static void MovedSam(char move, char[][] matrix, int[] samPosition)
        {
            switch(move)
            {
                case 'U':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[--samPosition[0]][samPosition[1]] = 'S';
                    break;

                case 'D':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[++samPosition[0]][samPosition[1]] = 'S';
                    break;

                case 'L':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[samPosition[0]][--samPosition[1]] = 'S';
                    break;

                case 'R':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[samPosition[0]][++samPosition[1]] = 'S';
                    break;
            }
        }

        private static void CheckingEnemies(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if(matrix[row].Contains('b') && matrix[row].Contains('S'))
                {
                    int indexEnemy = Array.IndexOf(matrix[row], 'b');
                    int indexSam = Array.IndexOf(matrix[row], 'S');

                    if(indexEnemy < indexSam)
                    {
                        matrix[row][indexSam] = 'X';
                        Console.WriteLine($"Sam died at {row}, {indexSam}");
                        PrintMatrix(matrix);
                    }
                }
                else if(matrix[row].Contains('d') && matrix[row].Contains('S'))
                {
                    int indexEnemy = Array.IndexOf(matrix[row], 'd');
                    int indexSam = Array.IndexOf(matrix[row], 'S');

                    if(indexEnemy > indexSam)
                    {
                        matrix[row][indexSam] = 'X';
                        Console.WriteLine($"Sam died at {row}, {indexSam}");
                        PrintMatrix(matrix);
                    }
                }
            }
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

            Environment.Exit(0);
        }

        private static void UpdateEnemies(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'b')
                    {
                        if (col == matrix[row].Length - 1)
                        {
                            matrix[row][col] = 'd';
                        }
                        else
                        {
                            matrix[row][col] = '.';
                            matrix[row][++col] = 'b';
                        }
                    }
                    else if (matrix[row][col] == 'd')
                    {
                        if (col == 0)
                        {
                            matrix[row][col] = 'b';
                        }
                        else
                        {
                            matrix[row][col] = '.';
                            matrix[row][col - 1] = 'd';
                        }
                    }
                }
            }
        }

        private static void FillUpMatrix(char[][] matrix, int[] samPosition)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                string line = Console.ReadLine();

                matrix[i] = line.ToCharArray();

                if (matrix[i].Contains('S'))
                {
                    int indexRow = Array.IndexOf(matrix[i], 'S');

                    samPosition[0] = i;
                    samPosition[1] = indexRow;
                }
            }
        }
    }
}
