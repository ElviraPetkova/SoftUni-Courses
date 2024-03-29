﻿using System;
using System.Text.RegularExpressions;

namespace _06._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\b[A-Z][a-z]+)([ ])([A-Z][a-z]+)\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchNames = regex.Matches(text);

            Console.WriteLine(string.Join(" ", matchNames));
        }
    }
}
