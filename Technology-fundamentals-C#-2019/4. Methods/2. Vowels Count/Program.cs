using System;

namespace _2.Vowels_Count
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintVolursCount(text);
        }

        public static void PrintVolursCount(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u'
                     || text[i] == 'A' || text[i] == 'E' || text[i] == 'I' || text[i] == 'O' || text[i] == 'U')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
