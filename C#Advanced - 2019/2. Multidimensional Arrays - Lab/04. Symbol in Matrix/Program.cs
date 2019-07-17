using System;
using System.Linq;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] array = new char[size, size];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = text[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool exist = false;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if(symbol == array[row, col])
                    {
                        exist = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if(!exist)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
