using System;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("MergeFile.txt", true))
            {
                var firstReader = new StreamReader(@"04. Merge Files\FileOne.txt");
                var secondReader = new StreamReader(@"04. Merge Files\FileTwo.txt");

                while (true)
                {
                    string firstLine = firstReader.ReadLine();
                    string secondLine = secondReader.ReadLine();

                    if (firstLine == null && secondLine == null)
                    {
                        break;
                    }

                    if(firstLine != null)
                    {
                        writer.WriteLine(firstLine);
                    }

                    if(secondLine != null)
                    {
                        writer.WriteLine(secondLine);
                    }
                }

                firstReader.Close();
                secondReader.Close();
            }
        }
    }
}
