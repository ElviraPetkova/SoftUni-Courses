using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> collection = new Stack<char>();

            foreach (var item in input)
            {
                collection.Push(item);
            }

            while (collection.Count != 0)
            {
                Console.Write(collection.Pop());
            }
            Console.WriteLine();
        }
    }
}
