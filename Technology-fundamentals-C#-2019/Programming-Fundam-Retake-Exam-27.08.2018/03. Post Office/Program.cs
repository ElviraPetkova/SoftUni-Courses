using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args) //90/100
        {
            string[] textFromCharacters = Console.ReadLine().Split('|');
            string firstString = textFromCharacters[0];
            string secondString = textFromCharacters[1];
            string thirdString = textFromCharacters[2];

            string patternPerFirstString = @"([#|$|%|&|*])([A-Z]+)(\1)"; // first letter = first letter from third Group
            Regex regexPerFirstText = new Regex(patternPerFirstString);

            string patternPerSecondString = @"([\d]{2}):([\d]{2})";
            Regex regexPerSecondText = new Regex(patternPerSecondString); //TODO: ckecking firstGroup - only capital letters, and secondGroup - 1-20 symbols

            string patternPerThirdString = @"\b([A-Z])(\S)+";
            Regex regexPerThirdText = new Regex(patternPerThirdString); //TODO: cheking secondPart = ASCI code = firstGroup, lenght = secondGroup from secondText

            List<string> descriptWords = new List<string>();

            if (regexPerFirstText.IsMatch(firstString) && regexPerSecondText.IsMatch(secondString) && regexPerThirdText.IsMatch(thirdString))
            {
                MatchCollection matchesOnlyCapitalLetters = regexPerFirstText.Matches(firstString);

                var listOfCapitalLetters = new List<char>();

                foreach (Match item in matchesOnlyCapitalLetters)
                {
                    string capitalLetters = item.Groups[2].Value;

                    for (int i = 0; i < capitalLetters.Length; i++)
                    {
                        listOfCapitalLetters.Add(capitalLetters[i]);
                    }
                }

                MatchCollection matchesOnlyASCICode = regexPerSecondText.Matches(secondString);

                var dictionaryForSecondText = new List<string>();

                foreach (Match item in matchesOnlyASCICode)
                {
                    int letterInInt = int.Parse(item.Groups[1].Value);
                    char letter = (char)letterInInt;
                    char[] indexesInArray = item.Groups[2].Value.ToCharArray();
                    string indexes = item.Groups[2].Value;
                    if (indexesInArray[0] == '0')
                    {
                        indexes.Substring(1);
                    }

                    int lenght = int.Parse(indexes) + 1;

                    if(lenght >= 1 && lenght <= 20)
                    {
                        string information = $"{letter}:{lenght}";

                        if (listOfCapitalLetters.Contains(letter))
                        {
                            dictionaryForSecondText.Add(information);
                        }
                    }
                    
                }

                MatchCollection matchesOfWords = regexPerThirdText.Matches(thirdString);

                foreach (Match item in matchesOfWords)
                {
                    string word = item.Value;
                    char firstChar = char.Parse(item.Groups[1].Value);
                    int lenght = word.Length;

                    for (int i = 0; i < dictionaryForSecondText.Count; i++)
                    {
                        var currentInfo = dictionaryForSecondText[i].Split(':');
                        char oneChar = char.Parse(currentInfo[0]);
                        int lenghtOfWord = int.Parse(currentInfo[1]);

                        if(firstChar == oneChar && lenghtOfWord == lenght)
                        {
                            descriptWords.Add(word);
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, descriptWords));

        }
    }
}
