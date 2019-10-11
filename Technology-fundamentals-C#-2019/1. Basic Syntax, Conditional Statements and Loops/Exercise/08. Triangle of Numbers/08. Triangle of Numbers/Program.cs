using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
