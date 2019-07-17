using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueFromNumbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> evenNumbers = new Queue<int>();

            for (int i = 0; i < queueFromNumbers.Count; i++)
            {
                int currentNumber = queueFromNumbers.Dequeue();

                if(currentNumber % 2 == 0)
                {
                    evenNumbers.Enqueue(currentNumber);
                }

                queueFromNumbers.Enqueue(currentNumber);
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
