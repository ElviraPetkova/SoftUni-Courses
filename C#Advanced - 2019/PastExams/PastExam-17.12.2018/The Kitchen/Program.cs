namespace The_Kitchen
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            Stack<int> knives = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> forks = new Queue<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> set = new Queue<int>();

            while (knives.Any() && forks.Any())
            {
                int knive = knives.Pop();
                int fork = forks.Peek();

                //fork > knive - remove knive

                if (knive == fork)
                {
                    forks.Dequeue();
                    knives.Push(++knive);
                }
                else if(knive > fork)
                {
                    forks.Dequeue();
                    set.Enqueue(knive + fork);
                }
            }

            Console.WriteLine($"The biggest set is: {set.Max()}");
            Console.WriteLine(string.Join(" ", set));
        }
    }
}
