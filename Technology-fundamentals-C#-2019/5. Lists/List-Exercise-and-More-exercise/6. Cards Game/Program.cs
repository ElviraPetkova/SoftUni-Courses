using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int cartPerFisrtPlayer = firstPlayer[0];
                int cartPerSecondPlayer = secondPlayer[0];

                if(cartPerFisrtPlayer == cartPerSecondPlayer)
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if(cartPerFisrtPlayer > cartPerSecondPlayer)
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                    firstPlayer.Add(cartPerFisrtPlayer);
                    firstPlayer.Add(cartPerSecondPlayer);
                }
                else if(cartPerSecondPlayer > cartPerFisrtPlayer)
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                    secondPlayer.Add(cartPerSecondPlayer);
                    secondPlayer.Add(cartPerFisrtPlayer);
                }
            }

            if(firstPlayer.Count > 0)
            {
                int sum = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondPlayer.Count > 0)
            {
                int sum = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }

        }
    }
}
