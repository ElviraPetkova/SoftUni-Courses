using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("Output.txt"))
            {
                using (var reader = new StreamReader(@"Resources\02. Line Numbers\Input.txt"))
                {
                    int counter = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if(line == null)
                        {
                            break;
                        }

                        string currentLine = $"{counter}. {line}";

                        writer.WriteLine(currentLine);

                        counter++;
                    }
                }
            }
        }
    }
}
