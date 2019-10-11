using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = 0; i < endIndex; i++)
            {
                for (int j = 0; j < endIndex; j++)
                {
                    for (int k = 0; k < endIndex; k++)
                    {
                        Console.WriteLine($"{(char)(i + 97)}{(char)(j + 97)}{(char)(k + 97)}");
                    }
                }
            }
        }
    }
}
