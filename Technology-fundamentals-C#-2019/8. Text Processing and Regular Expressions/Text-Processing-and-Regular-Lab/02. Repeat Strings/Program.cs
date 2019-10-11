using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int lenghtOneWord = text[i].Length;

                for (int j = 0; j < lenghtOneWord; j++)
                {
                    result.Append(text[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
