using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            var emojiCode = Console.ReadLine().Split(':').Select(int.Parse).ToList();

            int sumOfEmojiCode = emojiCode.Sum();

            string pattern = @"(?<= )[:][a-z]{4,}[:](?=[ ,.!?])";
            Regex regex = new Regex(pattern);

            List<string> allEmoji = new List<string>();
            int emojiPower = 0;

            var result = new List<string>();

            if (regex.IsMatch(message))
            {
                MatchCollection matches = regex.Matches(message);
                bool equal = false;
                foreach (Match match in matches)
                {
                    result.Add(match.Value);

                    var emoji = match.Value.ToCharArray();
                    var currentEmoji = new List<int>();
                    foreach (char character in emoji)
                    {
                        if(character == ':')
                        {
                            continue;
                        }
                        emojiPower += character;
                        currentEmoji.Add(character);
                    }
                    
                    if (currentEmoji.Sum() == sumOfEmojiCode)
                    {
                        equal = true;
                    }
                   
                }

                if(equal)
                {
                    emojiPower *= 2;
                }
               
                Console.WriteLine($"Emojis found: {string.Join(", ", result)}");
            }

            Console.WriteLine($"Total Emoji Power: {emojiPower}");
        }

    }
}
