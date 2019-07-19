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
            /*
                Have BUG: don't split "...".
                Example: two words: "there...it" => one word: "there:it"
                This is incorect.
             */

            var dictionaryFromWordsCount = new Dictionary<string, int>();

            using (var reader = new StreamReader(@"Resources\03. Word Count\words.txt"))
            {
                while (true)
                {
                    string lineOfWord = reader.ReadLine();

                    if(lineOfWord == null)
                    {
                        break;
                    }

                    string[] words = lineOfWord.Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (dictionaryFromWordsCount.ContainsKey(words[i]) == false)
                        {
                            dictionaryFromWordsCount.Add(words[i], 0);
                        }
                    }
                }
            }

            using (var secondReader = new StreamReader(@"Resources\03. Word Count\text.txt"))
            {
                while (true)
                {
                    string line = secondReader.ReadLine();

                    if(line == null)
                    {
                        break;
                    }

                    string[] text = line.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < text.Length; i++)
                    {
                        string oneWord = text[i].ToLower().Trim(new char[] { '-', ':', ';', '.', '?', '!', '(', ')' , ','});

                        if (oneWord.Contains("..."))
                        {
                            string[] moreWords = oneWord.Split("...", StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < moreWords.Length; j++)
                            {
                                if (dictionaryFromWordsCount.ContainsKey(moreWords[j]))
                                {
                                    dictionaryFromWordsCount[moreWords[j]]++;
                                }

                                Console.WriteLine(moreWords[j]);
                            }
                        }

                        Console.WriteLine(oneWord);

                        if (dictionaryFromWordsCount.ContainsKey(oneWord))
                        {
                            dictionaryFromWordsCount[oneWord]++;
                        }
                    }
                }
            }

            var sortedWordByCount = dictionaryFromWordsCount
                .OrderByDescending(w => w.Value);

            using (var writer = new StreamWriter("Output.txt"))
            {
                writer.WriteLine($"{string.Join(Environment.NewLine, sortedWordByCount.Select(x=> $"{x.Key} - {x.Value}"))}");
            }

        }
    }
}
