using System;

namespace TronRacers
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            var firstPlayerPosition = new int[2];
            var secondPlayerPosition = new int[2];

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];

                    if(input[j] == 'f')
                    {
                        firstPlayerPosition[0] = i;
                        firstPlayerPosition[1] = j;
                    }
                    else if(input[j] == 's')
                    {
                        secondPlayerPosition[0] = i;
                        secondPlayerPosition[1] = j;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstPlayerCommand = command[0];
                string secondPlayerCommand = command[1];

                firstPlayerPosition = PlayerMove(matrix, firstPlayerPosition, firstPlayerCommand);
                if(matrix[firstPlayerPosition[0], firstPlayerPosition[1]] == '*')
                {
                    matrix[firstPlayerPosition[0], firstPlayerPosition[1]] = 'f';
                }
                else
                {
                    matrix[firstPlayerPosition[0], firstPlayerPosition[1]] = 'x';
                    break;
                }

                secondPlayerPosition = PlayerMove(matrix, secondPlayerPosition, secondPlayerCommand);
                if(matrix[secondPlayerPosition[0], secondPlayerPosition[1]] == '*')
                {
                    matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 's';
                }
                else
                {
                    matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 'x';
                    break;
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static int[] PlayerMove(char[,] matrix, int[] playerPosition, string command)
        {
            if(command == "up")
            {
                playerPosition[0]--;
            }
            else if(command == "down")
            {
                playerPosition[0]++;
            }
            else if(command == "left")
            {
                playerPosition[1]--;
            }
            else if(command == "right")
            {
                playerPosition[1]++;
            }

            if(playerPosition[0] == -1)
            {
                playerPosition[0] = matrix.GetLength(0) - 1;
            }
            else if(playerPosition[0] == matrix.GetLength(0))
            {
                playerPosition[0] = 0;
            }

            if(playerPosition[1] == -1)
            {
                playerPosition[1] = matrix.GetLength(0) - 1;
            }
            else if(playerPosition[1] == matrix.GetLength(0))
            {
                playerPosition[1] = 0;
            }

            return playerPosition;
        }
    }
}
