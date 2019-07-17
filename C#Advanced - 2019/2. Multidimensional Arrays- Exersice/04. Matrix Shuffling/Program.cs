using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arrayRow = info[0];
            int arrayCol = info[1];

            string[,] array = new string[arrayRow, arrayCol];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                string[] someText = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = someText[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0]; //swap row1 col1 row2c col2

                if (command != "swap" || tokens.Length < 5 || tokens.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int firstRow = int.Parse(tokens[1]);
                int firstCol = int.Parse(tokens[2]);
                int secondRow = int.Parse(tokens[3]);
                int secondCol = int.Parse(tokens[4]);

                if(firstRow < 0 || firstRow >= arrayRow || firstCol < 0 || firstCol >= arrayCol
                    || secondRow < 0 || secondRow >= arrayRow || secondCol < 0 || secondCol >= arrayCol)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string firstElement = array[firstRow, firstCol];
                string secondElement = array[secondRow, secondCol];

                array[firstRow, firstCol] = secondElement;
                array[secondRow, secondCol] = firstElement;

                for (int row = 0; row < array.GetLength(0); row++)
                {
                    for (int col = 0; col < array.GetLength(1); col++)
                    {
                        Console.Write(array[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }

            
        }
    }
}
