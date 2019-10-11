using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string pattern = @"@(.+?)\|.*?#(.+?)\*";
            Regex regex = new Regex(pattern);

            string patternSecond = @"#(.+?)\*.*?@(.+?)\|";
            Regex regexPerSecond = new Regex(patternSecond);

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if(regex.IsMatch(input))
                {
                    MatchCollection matchInfo = regex.Matches(input);

                    foreach (Match match in matchInfo)
                    {
                        string name = match.Groups[1].Value;
                        string age = match.Groups[2].Value;

                        string curentText = $"{name} is {age} years old.";
                        Console.WriteLine(curentText);
                    }
                }
                else if (regexPerSecond.IsMatch(input))
                {
                    Match match = regexPerSecond.Match(input);
                    string age = match.Groups[1].Value;
                    string name = match.Groups[2].Value;

                    string curentText = $"{name} is {age} years old.";
                    Console.WriteLine(curentText);
                }
            }
        }
    }
}
