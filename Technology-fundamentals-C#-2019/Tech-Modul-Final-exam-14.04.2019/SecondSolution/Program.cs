using System;
using System.Text.RegularExpressions;

namespace Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([A-Za-z\d\!\@\#\$\?]+)=(\d+)<<(.+)";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Last note")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    Match matches = regex.Match(input);

                    string currentName = matches.Groups[1].Value;
                    int lenght = int.Parse(matches.Groups[2].Value);
                    string geohashCode = matches.Groups[3].Value;

                    if(lenght == geohashCode.Length)
                    {
                        string resultName = ReturnName(currentName);
                        Console.WriteLine($"Coordinates found! {resultName} -> {geohashCode}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }

        private static string ReturnName(string currentName)
        {
            string name = string.Empty;

            for (int i = 0; i < currentName.Length; i++)
            {
                if (char.IsLetterOrDigit(currentName[i]))
                {
                    name += currentName[i];
                }
            }

            return name;
        }
    }
}
