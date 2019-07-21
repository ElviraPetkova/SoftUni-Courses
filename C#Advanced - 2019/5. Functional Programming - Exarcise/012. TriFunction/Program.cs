using System;
using System.Linq;

namespace _012._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Func<string, char[]> funcToCharArr = x => x.ToCharArray();
            Func<char, int> castFunc = y => (int)y;
            Func<string, bool> finalFunc = x => funcToCharArr(x)
                                .Select(castFunc)
                                .Sum() >= count;

            Console.WriteLine(Console.ReadLine()
                .Split()
                .FirstOrDefault(finalFunc));
        }
    }
}
