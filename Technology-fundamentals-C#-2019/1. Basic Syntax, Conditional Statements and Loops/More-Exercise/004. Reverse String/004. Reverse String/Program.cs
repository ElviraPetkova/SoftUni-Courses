using System;

namespace _004._Reverse_String
{
    class Program
    {
        static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            text.ToString();
            Console.WriteLine(text);
        }
    }
}
