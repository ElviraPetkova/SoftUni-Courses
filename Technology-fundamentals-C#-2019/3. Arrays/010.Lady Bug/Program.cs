using System;
using System.Linq;

namespace _010.Lady_Bug
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexesOfLady = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < indexesOfLady.Length; i++)
            {
                if(indexesOfLady[i] >= 0 && indexesOfLady[i] < fieldSize)
                {
                    field[indexesOfLady[i]] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                int ladyIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);

                if(ladyIndex < 0 || ladyIndex > field.Length - 1 || field[ladyIndex] == 0 || flyLenght == 0)
                {
                    continue;
                }

                field[ladyIndex] = 0;

                if(flyLenght < 0)
                {
                    if(direction == "left")
                    {
                        direction = "right";
                    }
                    else if(direction == "right")
                    {
                        direction = "left";
                    }

                    flyLenght *= (-1); 
                }

                if(direction == "right")
                {
                    ladyIndex += flyLenght;
                    while (ladyIndex < field.Length && field[ladyIndex] == 1)
                    {
                        ladyIndex += flyLenght;
                    }

                    if(ladyIndex < field.Length)
                    {
                        field[ladyIndex] = 1;
                    }

                }
                else if(direction == "left")
                {
                    ladyIndex -= flyLenght;

                    if(ladyIndex < 0)
                    {
                        continue;
                    }

                    while (ladyIndex >= 0 && field[ladyIndex] == 1)
                    {
                        ladyIndex -= flyLenght;
                    }

                    if(field[ladyIndex] >= 0)
                    {
                        field[ladyIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
