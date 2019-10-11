using System;
using System.Linq;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            char[] characters = new char[] { firstChar, secondChar, thirdChar };
            characters = characters.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", characters));
        }
    }
}
