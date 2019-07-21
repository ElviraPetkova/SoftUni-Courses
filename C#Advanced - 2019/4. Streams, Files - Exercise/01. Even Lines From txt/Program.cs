using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01._Even_Lines_From_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            var replaceCharacters = new char[] { '-', ',', '.', '!', '?' };
            int counter = 0;

            using (var reader = new StreamReader(@"Resourse\text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if(counter % 2 == 0)
                    {
                        string rezultString = ReversedString(line);
                        string replacedString = ReplasingSymbols(rezultString, replaceCharacters);

                        Console.WriteLine(replacedString);
                    }

                    counter++;
                }
            }
        }

        private static string ReplasingSymbols(string rezultString, char[] replaceCharacters)
        {
            foreach (var item in replaceCharacters)
            {
                rezultString = rezultString.Replace(item, '@');
            }

            return rezultString;
        }

        private static string ReversedString(string line)
        {
            var rezultText = new List<string>();

            string[] arrayOfLine = line.Split(' ');

            for (int i = arrayOfLine.Length - 1; i >= 0; i--)
            {
                rezultText.Add(arrayOfLine[i]);
            }

            return new string(string.Join(" ", rezultText));
        }
    }
}
