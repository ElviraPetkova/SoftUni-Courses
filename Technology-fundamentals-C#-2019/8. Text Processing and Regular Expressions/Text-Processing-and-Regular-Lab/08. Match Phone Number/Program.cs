using System;
using System.Text.RegularExpressions;

namespace _08._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\+359([- \s])2\1[0-9]{3}\1[0-9]{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchPhoneNumbers = regex.Matches(text);

            Console.WriteLine(string.Join(", ", matchPhoneNumbers));
        }
    }
}
