using System;
using System.Linq;

namespace _3._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int lastIndexOfPap = path.LastIndexOf('\\');
            string nameAndExtension = path.Substring(lastIndexOfPap + 1);

            int indexOfPoint = nameAndExtension.LastIndexOf('.');
            string name = nameAndExtension.Substring(0, indexOfPoint);
            string extension = nameAndExtension.Substring(indexOfPoint + 1, nameAndExtension.Length - name.Length - 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
