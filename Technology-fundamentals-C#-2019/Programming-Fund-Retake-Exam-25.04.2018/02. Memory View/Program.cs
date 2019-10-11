using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string rezult = string.Empty;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Visual Studio crash")
                {
                    break;
                }

                rezult += input + " ";
            }

            string[] tokens = rezult.Split(' ');   //32656 19759 32763 0 8 0
            List<string> names = new List<string>();

            for (int i = 0; i < tokens.Length - 5; i++)
            {
                if (tokens[i] == "32656" && tokens[i + 1] == "19759" && tokens[i + 2] == "32763"
                    && tokens[i + 3] == "0" && tokens[i + 5] == "0")
                {
                    int lenghtOfWord = int.Parse(tokens[i + 4]);

                    string word = string.Empty;

                    for (int j = i + 6; j < i + 6 + lenghtOfWord; j++)
                    {
                        word += (char)(int.Parse(tokens[j]));
                    }

                    names.Add(word);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
