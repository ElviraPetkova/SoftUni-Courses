using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encrypted = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char newChar = (char)(text[i] + 3);
                encrypted += newChar;
            }

            Console.WriteLine(encrypted);
        }
    }
}
