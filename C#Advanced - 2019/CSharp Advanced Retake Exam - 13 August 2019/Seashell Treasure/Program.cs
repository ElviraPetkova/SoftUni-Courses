using System;
using System.Collections.Generic;
using System.Linq;

namespace Seashell_Treasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeRow = int.Parse(Console.ReadLine());
            char[][] jaggetMatrix = new char[sizeRow][];

            for (int row = 0; row < sizeRow; row++)
            {
                jaggetMatrix[row] = Console.ReadLine()
                    .Replace(" ", "").ToCharArray();
            }

            List<char> collected = new List<char>();
            int stolen = 0;

            while (true)
            {
                var lineOfCommands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = lineOfCommands[0];

                if(command == "Sunset")
                {
                    break;
                }

                int row = int.Parse(lineOfCommands[1]);
                int col = int.Parse(lineOfCommands[2]);

                if(command == "Collect" && ValidationPosition(row, col, jaggetMatrix) && jaggetMatrix[row][col] != '-')
                {
                    collected.Add(jaggetMatrix[row][col]);
                    jaggetMatrix[row][col] = '-';
                }
                else if(command == "Steal")
                {
                    string direction = lineOfCommands[3];
                    if(ValidationPosition(row, col, jaggetMatrix))
                    {
                        stolen = MovePosition(jaggetMatrix, row, col, direction, stolen);
                    }
                }
            }

            foreach (var row in jaggetMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            if (collected.Count != 0)
            {
                Console.WriteLine($"Collected seashells: {collected.Count} -> {string.Join(", ", collected)}");
            }
            else
            {
                Console.WriteLine($"Collected seashells: {collected.Count}");
            }

            Console.WriteLine($"Stolen seashells: {stolen}");
        }

        private static int MovePosition(char[][] jaggetMatrix, int row, int col, string direction, int currentStolen)
        {
            switch (direction)
            {
                case "up": currentStolen += MoveUp(jaggetMatrix, row, col); break;
                case "down": currentStolen += MoveDown(jaggetMatrix, row, col); break;
                case "left": currentStolen += MoveLeft(jaggetMatrix, row, col); break;
                case "right": currentStolen += MoveRight(jaggetMatrix, row, col); break;             
            }

            return currentStolen;
        }

        private static int MoveRight(char[][] jaggetMatrix, int row, int col)
        {
            int result = 0;
            for (int i = col; i <= col + 3; i++)
            {
                if (ValidationPosition(row, i, jaggetMatrix) && jaggetMatrix[row][i] != '-')
                {
                    result++;
                    jaggetMatrix[row][i] = '-';
                }
            }

            return result;
        }

        private static int MoveLeft(char[][] jaggetMatrix, int row, int col)
        {
            int result = 0;
            for (int i = col; i >= col - 3; i--)
            {
                if (ValidationPosition(row, i, jaggetMatrix) && jaggetMatrix[row][i] != '-')
                {
                    result++;
                    jaggetMatrix[row][i] = '-';
                }
            }

            return result;
        }

        private static int MoveDown(char[][] jaggetMatrix, int row, int col)
        {
            int result = 0;
            for (int i = row; i <= row + 3; i++)
            {
                if (ValidationPosition(i, col, jaggetMatrix) && jaggetMatrix[i][col] != '-')
                {
                    result++;
                    jaggetMatrix[i][col] = '-';
                }
            }

            return result;
        }

        private static int MoveUp(char[][] jaggetMatrix, int row, int col)
        {
            int result = 0;
            for (int i = row - 1; i >= row - 3; i--)
            {
                if(ValidationPosition(i, col, jaggetMatrix) && jaggetMatrix[i][col] != '-')
                {
                    result++;
                    jaggetMatrix[i][col] = '-';
                }
            }

            return result;
        }

        private static bool ValidationPosition(int row, int col, char[][] jaggetMatrix)
        {
            return row >= 0 && row < jaggetMatrix.Length && col >= 0 && col < jaggetMatrix[row].Length
                ? true
                : false;
        }
    }
}
