using System;

namespace Space_Station_Establishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size][];
            int[] positionByStation = new int[2];

            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine();
                matrix[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];

                    if(matrix[row][col] == 'S')
                    {
                        positionByStation[0] = row;
                        positionByStation[1] = col;
                    }
                }
            }

            int energy = 0;

            while (true)
            {
                string command = Console.ReadLine();
                positionByStation = MovePosition(matrix, positionByStation, command);

                if (!ChekingPosition(size, positionByStation))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }

                if (char.IsDigit(matrix[positionByStation[0]][positionByStation[1]]))
                {
                    int currentEnergy = int.Parse(matrix[positionByStation[0]][positionByStation[1]].ToString());
                    energy += currentEnergy;
                    matrix[positionByStation[0]][positionByStation[1]] = 'S';
                }

                if(matrix[positionByStation[0]][positionByStation[1]] == 'O')
                {
                    int[] otherBlackHolePosition = SearhBlackHolePosition(matrix, positionByStation, size);
                    matrix[positionByStation[0]][positionByStation[1]] = '-';
                    matrix[otherBlackHolePosition[0]][otherBlackHolePosition[1]] = 'S';
                    positionByStation = otherBlackHolePosition;
                }

                if(energy >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }

            Console.WriteLine($"Star power collected: {energy}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

        }

        private static int[] SearhBlackHolePosition(char[][] matrix, int[] positionByStation, int size)
        {
            int[] blackHole = new int[2];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(matrix[row][col] == 'O')// && matrix[row][col] != matrix[positionByStation[0]][positionByStation[1]])
                    {
                        blackHole[0] = row;
                        blackHole[1] = col;
                        break;
                    }
                }
            }

            return blackHole;
        }

        private static bool ChekingPosition(int size, int[] positionByStation)
        {
            if(positionByStation[0] < 0 || positionByStation[0] >= size 
                || positionByStation[1] < 0 || positionByStation[1] >= size)
            {
                return false;
            }

            return true;
        }

        private static int[] MovePosition(char[][] matrix, int[] positionByStation, string command)
        {
            matrix[positionByStation[0]][positionByStation[1]] = '-';

            switch (command)
            {
                case "up": positionByStation[0]--; break;
                case "down": positionByStation[0]++; break;
                case "left": positionByStation[1]--; break;
                case "right": positionByStation[1]++; break;
            }

            return positionByStation;
        }
    }
}
