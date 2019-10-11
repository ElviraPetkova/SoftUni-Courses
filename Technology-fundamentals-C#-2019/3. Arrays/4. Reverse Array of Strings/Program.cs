using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayFromChars = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //arrayFromChars = arrayFromChars.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", arrayFromChars));

            for (int i = 0; i < arrayFromChars.Length / 2; i++)
            {
                string firstChar = arrayFromChars[i];
                string lastChar = arrayFromChars[arrayFromChars.Length - i - 1];
                arrayFromChars[i] = lastChar;
                arrayFromChars[arrayFromChars.Length - i - 1] = firstChar;
            }

            foreach (var ch in arrayFromChars)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }
}
