using System;

namespace _7.NxN_Matrix
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }

        public static void PrintMatrix(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= number; col++)
                {
                    string matrix = string.Join(" ", number);
                    Console.Write(matrix + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
