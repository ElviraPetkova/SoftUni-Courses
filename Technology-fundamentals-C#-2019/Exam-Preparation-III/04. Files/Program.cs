using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Files
{
    class File
    {
        
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }
        
        public string Name { get; set; }

        public long Size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());

           var dictionary = new Dictionary<string, Dictionary<string, List<File>>>(); 

            for (int i = 0; i < numberOfLine; i++)
            {
                string path = Console.ReadLine();
                //Games\Pirates\Start\keygen.exe;1024

                int firstIndex = path.IndexOf('\\');
                string rootDirectory = path.Substring(0, firstIndex);

                int lastIndexPaps = path.LastIndexOf('\\');
                string currentPath = path.Substring(lastIndexPaps + 1);

                int lastIndexOfComma = currentPath.LastIndexOf(';');

                string currentSizeFile = currentPath.Substring(lastIndexOfComma + 1);
                long sizeFile = long.Parse(currentSizeFile);

                string nameFile = currentPath.Substring(0, lastIndexOfComma); // nameFile = contains name and extension
                int lastIndexOfPoint = nameFile.LastIndexOf('.');

                string extension = nameFile.Substring(lastIndexOfPoint + 1);


                if (dictionary.ContainsKey(rootDirectory) == false)
                {
                    dictionary.Add(rootDirectory, new Dictionary<string, List<File>>());
                    dictionary[rootDirectory].Add(extension, new List<File>());
                    File currentFile = new File(nameFile, sizeFile);
                    dictionary[rootDirectory][extension].Add(currentFile);
                }
                else
                {
                    if (dictionary[rootDirectory].ContainsKey(extension) == false)
                    {
                        dictionary[rootDirectory].Add(extension, new List<File>());
                    }

                    File currentFile = new File(nameFile, sizeFile);

                    bool haveNameFile = false;
                    foreach (var kvp in dictionary[rootDirectory])
                    {
                        foreach (var file in kvp.Value)
                        {
                            string currentName = file.Name;
                            if(currentName == nameFile)
                            {
                                file.Size = sizeFile;
                                haveNameFile = true;
                                break;
                            }
                        }

                        if(haveNameFile ==true)
                        {
                            break;
                        }
                    }

                    if(haveNameFile == false)
                    {
                        dictionary[rootDirectory][extension].Add(currentFile);
                    }
                }
            }

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string searchingExtension = input[0];
            string searchingRoot = input[2];

            if (dictionary.ContainsKey(searchingRoot))
            {
                if (dictionary[searchingRoot].ContainsKey(searchingExtension))
                {
                    var result = dictionary[searchingRoot][searchingExtension].ToList();
                    if(result.Count > 0)
                    {
                        foreach (File file in result.OrderByDescending(x=>x.Size).ThenBy(x=>x.Name))
                        {
                            Console.WriteLine($"{file.Name} - {file.Size} KB");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
