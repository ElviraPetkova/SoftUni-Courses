using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _10._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\D+)([\d]+)";
            Regex regex = new Regex(pattern);

            string line = Console.ReadLine();

            if (regex.IsMatch(line))
            {
                MatchCollection matchText = regex.Matches(line);

                StringBuilder sbText = new StringBuilder();

                foreach (Match match in matchText)
                {
                    string newText = match.Groups[1].Value.ToUpper();
                    int count = int.Parse(match.Groups[2].Value);

                    for (int i = 0; i < count; i++)
                    {
                        sbText.Append(newText);
                    }
                }

                int lenght = sbText.ToString().Distinct().Count();

                Console.WriteLine($"Unique symbols used: {lenght}");
                Console.WriteLine(sbText);
            }
        }
    }
}
