using System;
using System.Linq;

namespace _02._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenhgtOfField = int.Parse(Console.ReadLine());

            int[] field = new int[lenhgtOfField];

            int[] busyCells = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < busyCells.Length; i++)
            {
                if (busyCells[i] >= 0 && busyCells[i] < lenhgtOfField)
                {
                    field[busyCells[i]] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    Console.WriteLine(string.Join(" ", field));
                    break;
                }

                string[] tokens = input.Split();

                int startIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);

                if(startIndex < 0 || startIndex > field.Length - 1 || field[startIndex] == 0 || flyLenght == 0)
                {
                    continue;
                }

                if(flyLenght < 0)
                {
                    flyLenght *= (-1);

                    switch (direction)
                    {
                        case "left": direction = "right"; break;
                        case "right": direction = "left"; break;
                    }
                }

                field[startIndex] = 0;

                if(direction == "right")
                {
                    startIndex += flyLenght;
                    if(startIndex > field.Length)
                    {
                        continue;
                    }

                    while(startIndex < field.Length && field[startIndex] == 1)
                    {
                        startIndex += flyLenght;
                    }

                    if(startIndex < field.Length)
                    {
                        field[startIndex] = 1;
                    }
                }
                else if(direction == "left")
                {
                    startIndex -= flyLenght;
                    if(startIndex < 0)
                    {
                        continue;
                    }

                    while (startIndex >= 0 && field[startIndex] == 1)
                    {
                        startIndex -= flyLenght;
                    }

                    if(startIndex >= 0)
                    {
                        field[startIndex] = 1;
                    }
                }
            }
        }
    }
}
