using System;

namespace _6.Middle_Characters
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(MiddleChar(text));
        }

        public static string MiddleChar(string text)
        {
            string middleChar = string.Empty;

            int lenght = text.Length - 1;

            if(lenght % 2 == 0)
            {
                middleChar = text[lenght / 2] + "";
            }
            else
            {
                middleChar = text[lenght / 2] + "" +  text[((lenght / 2) + 1)] + "";
            }

            return middleChar;
        }
    }
}
