using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] array = new int[size, size];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = numbers[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }

                var info = input.Split(" ");
                string command = info[0];
                int row = int.Parse(info[1]);
                int col = int.Parse(info[2]);
                int value = int.Parse(info[3]);

                if(row > size - 1 || col > size - 1 || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if(command == "Add")
                {
                    array[row, col] += value;
                }
                else if(command == "Subtract")
                {
                    array[row, col] -= value;
                }
            }
        }
    }
}
