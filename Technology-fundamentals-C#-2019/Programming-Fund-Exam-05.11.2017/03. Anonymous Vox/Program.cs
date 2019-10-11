using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string pattern = @"(?<start>[A-Za-z]+)(?<placeholder>.+)(?<end>\1)";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(text))
            {
                MatchCollection matches = regex.Matches(text);

                int counter = 0;
                foreach (Match match in matches)
                {
                    if(counter > values.Count - 1)
                    {
                        break;
                    }

                    string start = match.Groups["start"].Value;
                    string place = match.Groups["placeholder"].Value;
                    string end = match.Groups["end"].Value;

                    string currentPlaceHolder = values[counter];
                    string resultString = start + currentPlaceHolder + end;

                    text = text.Replace(match.Value, resultString);

                    counter++;
                }
            }

            Console.WriteLine(text);
        }
    }
}
