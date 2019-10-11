using System;

namespace _9.Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string numberOrCommand = Console.ReadLine();

                if(numberOrCommand == "END")
                {
                    break;
                }

                bool palindrom = Palindrom(numberOrCommand);
                Console.WriteLine(palindrom.ToString().ToLower());
            }
        }

        public static bool Palindrom(string text)
        {
            bool palindrom = true;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[text.Length - i - 1])
                {
                    continue;
                }
                else
                {
                    palindrom = false;
                }
            }

            return palindrom;
        }
    }
}
