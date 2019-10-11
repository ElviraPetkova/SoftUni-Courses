using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int halfOfN = N / 2;
            int count = 0;

            while (true)
            {
                if (N < M)
                {
                    Console.WriteLine(N);
                    Console.WriteLine(count);
                    break;
                }
                N -= M;
                count++;

                if (N == halfOfN && Y > 0)
                {
                    N /= Y;
                }
            }
        }
    }
}
