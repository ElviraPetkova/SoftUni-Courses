using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternPerDidimon = @"[^A-Za-z-]+";
            Regex regexPerDidi = new Regex(patternPerDidimon);

            string patternPerBojo = @"[A-Za-z]+-[A-Za-z]+";
            Regex regexPerBojo = new Regex(patternPerBojo);

            int round = 1;

            while (true)
            {
                if(round % 2== 1) //didi
                {
                    if (regexPerDidi.IsMatch(input))
                    {
                        Match match = regexPerDidi.Match(input);
                        input = input.Substring(match.Index + match.Length);
                        Console.WriteLine(match.Value);
                    }
                    else
                    {
                        return;
                    }
                }
                else //match bojo
                {
                    if (regexPerBojo.IsMatch(input))
                    {
                        Match match = regexPerBojo.Match(input);
                        input = input.Substring(match.Index + match.Length);
                        Console.WriteLine(match.Value);
                    }
                    else
                    {
                        return;
                    }
                }

                round++;
            }
        }
    }
}
