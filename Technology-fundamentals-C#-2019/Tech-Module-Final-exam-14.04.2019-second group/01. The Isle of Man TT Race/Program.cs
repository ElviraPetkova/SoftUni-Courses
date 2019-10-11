using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _01._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([#$%*&])([A-Za-z]+)(\1)=(\d+)!!(.+)$";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    //TODO: if coordinates found - return program, else - continue

                    Match match = regex.Match(input);
                    string name = match.Groups[2].Value;
                    int lenght = int.Parse(match.Groups[4].Value);
                    string decryptMessage = match.Groups[5].Value;

                    if(decryptMessage.Length != lenght)
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    else
                    {
                        string geohashCode = IncreaseEachSymbols(decryptMessage, lenght);

                        Console.WriteLine($"Coordinates found! {name} -> {geohashCode}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }

        private static string IncreaseEachSymbols(string decryptMessage, int lenght)
        {
            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < decryptMessage.Length; i++)
            {
                char newChar = (char)(decryptMessage[i] + lenght);
                newString.Append(newChar);
            }

            return newString.ToString();
        }
    }
}
