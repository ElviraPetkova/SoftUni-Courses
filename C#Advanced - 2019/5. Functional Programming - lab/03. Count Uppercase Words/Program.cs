﻿using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
