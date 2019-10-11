using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetsPower = hornets.Sum();
                long bees = beehives[i];
                if (bees < hornetsPower)
                {
                    beehives[i] = 0;
                }
                else if (bees >= hornetsPower)
                {
                    beehives[i] = bees - hornetsPower;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }

                }
            }

            var lives = beehives.Where(x => x > 0).ToList();
            if (lives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", lives));
            }
            else if (hornets.Count > 0 && lives.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
