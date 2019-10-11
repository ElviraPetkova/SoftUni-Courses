namespace P03_JediGalaxy
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = FillUpMatrix(sizes);
            Ivo ivo = new Ivo();
            Evil evil = new Evil();

            string input;

            while((input = Console.ReadLine()) != "Let the Force be with you")
            {
                UpdateCoordinates(input, ivo, evil);
                MovedEvil(evil, matrix);
                MovedIvo(ivo, matrix);
            }

            Console.WriteLine(ivo.Score);
        }

        private static void MovedIvo(Ivo ivo, int[,] matrix)
        {
            while (ivo.Row >= 0)
            {
                if(ivo.Row < matrix.GetLength(0) && ivo.Col >= 0 && ivo.Col < matrix.GetLength(1))
                {
                    ivo.CollectPoints(matrix[ivo.Row, ivo.Col]);
                }

                ivo.UpdateCoordinates(ivo.Row - 1, ivo.Col + 1);
            }
        }

        private static void MovedEvil(Evil evil, int[,] matrix)
        {
            while (evil.Row >= 0)
            {
                if(evil.Row < matrix.GetLength(0) && evil.Col >= 0 && evil.Col < matrix.GetLength(1))
                {
                    matrix[evil.Row, evil.Col] = 0;
                }

                evil.UpdateCoordinates(evil.Row - 1, evil.Col - 1);
            }
        }

        private static void UpdateCoordinates(string input, Ivo ivo, Evil evil)
        {
            var ivoCoordinates = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            ivo.UpdateCoordinates(ivoCoordinates[0], ivoCoordinates[1]);

            input = Console.ReadLine();

            var evilCoordinates = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            evil.UpdateCoordinates(evilCoordinates[0], evilCoordinates[1]);
        }

        private static int[,] FillUpMatrix(int[] sizes)
        {
            int rows = sizes[0];
            int cols = sizes[1];
            int count = 0;

            int[,] matrix = new int[rows, cols];

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    matrix[row, col] = count++;
                }
            }

            return matrix;
        }
    }
}
