using System;
using System.Collections.Generic;
using System.Linq;

namespace _012._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueOfCups = new Queue<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> stackOfBottles = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int lostWater = 0;

            while (queueOfCups.Count > 0 && stackOfBottles.Count > 0)
            {
                int oneCup = queueOfCups.Peek();
                int oneBottel = stackOfBottles.Peek();

                if(oneBottel >= oneCup)
                {
                    int leftWater = oneBottel - oneCup;
                    lostWater += leftWater;

                    queueOfCups.Dequeue();
                    stackOfBottles.Pop();
                }
                else
                {
                    int needWater = 0;
                    while (needWater < oneCup)
                    {
                        int currentWater = stackOfBottles.Pop();
                        needWater += currentWater;
                    }

                    int leftWater = needWater - oneCup;
                    lostWater += leftWater;

                    queueOfCups.Dequeue();
                }
            }

            if(queueOfCups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", queueOfCups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stackOfBottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {lostWater}");
        }
    }
}
