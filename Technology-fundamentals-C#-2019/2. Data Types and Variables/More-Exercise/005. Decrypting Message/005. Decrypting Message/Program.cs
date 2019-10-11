using System;

namespace _005._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counterOfChars = int.Parse(Console.ReadLine());
            string decryptedMessage = string.Empty;

            for (int i = 0; i < counterOfChars; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int newNumberOfChar = number + (int)(character);
                char newChar = (char)newNumberOfChar;
                decryptedMessage += newChar;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
