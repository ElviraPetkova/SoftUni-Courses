using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("RezultText.txt"))
            {
                using (var reader = new StreamReader(@"Resourse\text.txt"))
                {
                    int counter = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if(line == null)
                        {
                            break;
                        }

                        int letters = 0;
                        int punctuation = 0;

                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsPunctuation(line[i]))
                            {
                                punctuation++;
                            }
                            else if (char.IsLetter(line[i]))
                            {
                                letters++;
                            }
                        }

                        string newLine = $"Line {counter}: {line} ({letters})({punctuation})";

                        writer.WriteLine(newLine);

                        counter++;
                    }
                }
            }
        }
    }
}
