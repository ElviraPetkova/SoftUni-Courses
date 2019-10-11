using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                char[] reversed = input.Reverse().ToArray();

                Console.WriteLine($"{input} = {string.Join("", reversed)}");
            }
        }
    }
}
