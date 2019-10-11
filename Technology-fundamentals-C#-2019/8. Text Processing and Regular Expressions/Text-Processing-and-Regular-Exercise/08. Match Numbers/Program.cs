using System;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringAsNumberAndSymbols = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            Regex newRegex = new Regex(pattern);

            MatchCollection numbers = newRegex.Matches(stringAsNumberAndSymbols);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
