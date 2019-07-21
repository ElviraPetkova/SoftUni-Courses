using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryFromWords = new Dictionary<string, int>();

            using (var reader = new StreamReader(@"Resourse\words.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if(line == null)
                    {
                        break;
                    }

                    string[] splitedLine = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < splitedLine.Length; i++)
                    {
                        if(dictionaryFromWords.ContainsKey(splitedLine[i]) == false)
                        {
                            dictionaryFromWords.Add(splitedLine[i].ToLower(), 0);
                        }
                    }
                }
            }

            using (var secondReader = new StreamReader(@"Resourse\text.txt"))
            {
                while (true)
                {
                    string line = secondReader.ReadLine();

                    if(line == null)
                    {
                        break;
                    }

                    string[] splitedLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < splitedLine.Length; i++)
                    {
                        string oneWord = splitedLine[i]
                            .ToLower()
                            .Trim(new char[] { '-', ',', '!', '?', ';', ':', '(', ')'});

                        if (oneWord.Contains("..."))
                        {
                            string[] moreWords = oneWord.Split("...", StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < moreWords.Length; j++)
                            {
                                if (dictionaryFromWords.ContainsKey(moreWords[j]))
                                {
                                    dictionaryFromWords[moreWords[j]]++;
                                }
                            }
                        }

                        if (dictionaryFromWords.ContainsKey(oneWord.TrimEnd('.')))
                        {
                            dictionaryFromWords[oneWord.TrimEnd('.')]++;
                        }
                    }
                }
            }

            var sortedWordsByCount = dictionaryFromWords
                .OrderByDescending(w => w.Value);

            using (var writer = new StreamWriter("actualResults.txt"))
            {
                foreach (var kvp in sortedWordsByCount)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
              
            }

            bool isTrue = true;
            using (var reader1 = new StreamReader("actualResults.txt"))
            {
                using (var reader2 = new StreamReader(@"Resourse\expectedResult.txt"))
                {
                    while (true)
                    {
                        string lineFirstFile = reader1.ReadLine();
                        string lineSecondFile = reader2.ReadLine();

                        if (lineFirstFile == null || lineSecondFile == null)
                        {
                            break;
                        }

                        if (lineFirstFile == lineSecondFile)
                        {
                            continue;
                        }
                        else
                        {
                            isTrue = false;
                            break;
                        }
                    }
                }
            }

            using (var resultWriter = new StreamWriter("actualResults.txt", true))
            {
                resultWriter.WriteLine(isTrue);
            }
        }
    }
}
