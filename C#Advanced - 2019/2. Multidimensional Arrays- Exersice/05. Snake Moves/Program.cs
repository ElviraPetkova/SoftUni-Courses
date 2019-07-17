using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[] characters = Console.ReadLine().ToCharArray();

            char[][] array = new char[size[0]] [];

            Queue<char> queueOfChars = new Queue<char>(characters);

            for (int row = 0; row < array.GetLength(0); row++)
            {
                array[row] = new char[size[1]];

                for (int col = 0; col < size[1]; col++)
                {
                    char character = queueOfChars.Dequeue();
                    array[row][col] = character;
                    queueOfChars.Enqueue(character);
                }
            }

            Console
                .WriteLine(String
                .Join(Environment.NewLine, array
                .Select(r=> String.Join("", r))));
        }
    }
}
