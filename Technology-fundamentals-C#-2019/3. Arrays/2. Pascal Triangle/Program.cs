using System;

namespace _2._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArray[i] = new int[i + 1];

                for (int t = 0; t < i + 1; t++)
                {
                    if (t > 0 && t < jaggedArray[i].Length - 1)
                    {
                        jaggedArray[i][t] = jaggedArray[i - 1][t - 1] + jaggedArray[i - 1][t];
                    }
                    else
                    {
                        jaggedArray[i][t] = 1;
                    }
                }
            }

            foreach (int[] item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
