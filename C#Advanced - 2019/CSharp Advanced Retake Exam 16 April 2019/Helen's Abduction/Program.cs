using System;

namespace Helen_s_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energyByParis = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[numberOfRows][];
            int[] parisPosition = new int[2] { -1, -1 };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine();

                matrix[i] = new char[input.Length];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = input[j];

                    if (input[j] == 'P')
                    {
                        parisPosition[0] = i;
                        parisPosition[1] = j;
                    }
                }
            }

            while (true)
            {
                var commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = commands[0];
                int firstIndexByEnemy = int.Parse(commands[1]);
                int secondIndexByEnemy = int.Parse(commands[2]);

                matrix[firstIndexByEnemy][secondIndexByEnemy] = 'S';

                parisPosition = MoveParis(matrix, parisPosition, direction);
                energyByParis--;

                if (matrix[parisPosition[0]][parisPosition[1]] == 'H')
                {
                    matrix[parisPosition[0]][parisPosition[1]] = '-';
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energyByParis}");
                    break;
                }

                if (energyByParis <= 0)
                {
                    matrix[parisPosition[0]][parisPosition[1]] = 'X';
                    Console.WriteLine($"Paris died at {parisPosition[0]};{parisPosition[1]}.");
                    break;
                }

                if(matrix[parisPosition[0]][parisPosition[1]] == 'S')
                {
                    if(energyByParis - 2 > 0)
                    {
                        energyByParis -= 2;
                        matrix[parisPosition[0]][parisPosition[1]] = '-';
                    }
                    else
                    {
                        matrix[parisPosition[0]][parisPosition[1]] = 'X';
                        Console.WriteLine($"Paris died at {parisPosition[0]};{parisPosition[1]}.");
                        break;
                    }
                }

                
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
        }

        private static int[] MoveParis(char[][] matrix, int[] parisPosition, string direction)
        {
            matrix[parisPosition[0]][parisPosition[1]] = '-';

            switch (direction)
            {
                case "up":

                    if (parisPosition[0] - 1 >= 0) //becose paris[0] = -1; outOfRange
                    {
                        parisPosition[0]--;
                    }
                    
                    break;
                case "down":

                    if (parisPosition[0] + 1 < matrix.GetLength(0)) //becose paris[0] = matrix.Lenght
                    {
                        parisPosition[0]++;
                    }

                    break;
                case "left":
                    
                    if(parisPosition[1] - 1 >= 0)
                    {
                        parisPosition[1]--;
                    }

                    break;
                case "right":

                    if (parisPosition[1] + 1 < matrix.Length)
                    {
                        parisPosition[1]++;
                    }

                    break;
            }

            return parisPosition;
        }
    }
}
