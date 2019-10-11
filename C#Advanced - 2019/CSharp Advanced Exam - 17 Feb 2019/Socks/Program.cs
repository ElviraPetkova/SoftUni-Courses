using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    public class Program
    {
        public static void Main()
        {
            int[] firstSequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondSequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> leftSocks = new Stack<int>(firstSequence);
            Queue<int> rightSocks = new Queue<int>(secondSequence);

            Queue<int> pairs = new Queue<int>();

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int left = leftSocks.Pop();
                int right = rightSocks.Peek();

                if(left == right)
                {
                    rightSocks.Dequeue();
                    leftSocks.Push(++left);
                }
                else if(left > right)
                {
                    rightSocks.Dequeue();
                    pairs.Enqueue(left + right);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }

    }
}
