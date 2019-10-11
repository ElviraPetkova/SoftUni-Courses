using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (listOfNumbers.Count > 1)
            {
                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    if(listOfNumbers.Count(x => x != -1) == 1)
                    {
                        break;
                    }

                    if (listOfNumbers[i] < 0)
                    {
                        continue;
                    }

                    int attacker = i; //attacker = index; target = value
                    int target = listOfNumbers[i] % listOfNumbers.Count;

                    int diff = Math.Abs(target - attacker);

                    if (attacker == target) //attacker and target lost.
                    {
                        Console.WriteLine($"{attacker} performed harakiri");

                        listOfNumbers[target] = -1;
                    }
                    else if(diff % 2 == 0) //Attacker wins, Target lost.
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");

                        listOfNumbers[target] = -1;
                    }
                    else if (diff % 2 != 0) //Target wins, attacker lost.
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");

                        listOfNumbers[attacker] = -1;
                    }
                }

                listOfNumbers.RemoveAll(x => x < 0);
            }
        }
    }
}
