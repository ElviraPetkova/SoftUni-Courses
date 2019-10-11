using System;

namespace _010.Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(text, repeat));

            //second solution
            //string newText = RepeatString(text, repeat);
            //Console.WriteLine(newText);
        }

        public static string RepeatString(string text, int repeat)
        {
            string newText = string.Empty;
            for (int i = 0; i < repeat; i++)
            {
                newText += text;
            }

            return newText;
        }
    }
}
