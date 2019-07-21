using System;
using System.Linq;

namespace _01._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> printAction = Console.WriteLine;

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printAction);
        }
    }
}
