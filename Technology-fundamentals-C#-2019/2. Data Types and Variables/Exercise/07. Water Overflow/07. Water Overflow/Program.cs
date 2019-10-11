using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfFills = int.Parse(Console.ReadLine());

            int capasity = 255;
            int liters = 0;

            for (int i = 0; i < counterOfFills; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (liters + quantity > capasity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                liters += quantity;
            }

            Console.WriteLine(liters);
        }
    }
}
