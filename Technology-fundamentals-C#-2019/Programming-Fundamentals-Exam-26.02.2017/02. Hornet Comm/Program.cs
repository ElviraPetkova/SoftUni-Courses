using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternPerMessage = @"^(\d+)( <-> )([A-Za-z0-9]+)$";
            Regex regMessage = new Regex(patternPerMessage);

            string patternPerBroadcast = @"^(\D+)( <-> )([A-Za-z0-9]+)$";
            Regex regPerBroadcast = new Regex(patternPerBroadcast);

            List<string> listOfMessage = new List<string>();
            List<string> listOfBoardcast = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Hornet is Green")
                {
                    break;
                }

                if (regMessage.IsMatch(input))
                {
                    Match matchMess = regMessage.Match(input);

                    string currentCode = matchMess.Groups[1].Value;
                    string message = matchMess.Groups[3].Value;

                    char[] array = currentCode.ToCharArray();
                    Array.Reverse(array);
                    string code = new string(array);

                    string mess = code + " -> " + message;

                    listOfMessage.Add(mess);
                }
                else if (regPerBroadcast.IsMatch(input))
                {
                    Match matchBroad = regPerBroadcast.Match(input);

                    string message = matchBroad.Groups[1].Value;
                    string currentFrequency = matchBroad.Groups[3].Value;

                    string frequency = ChangeLettersCase(currentFrequency); //change small letter int capital and capital letter in small

                    string broadcast = frequency + " -> " + message;

                    listOfBoardcast.Add(broadcast);
                }
            }

            Console.WriteLine("Broadcasts:");
            if (listOfBoardcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, listOfBoardcast));
            }

            Console.WriteLine("Messages:");
            if(listOfMessage.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, listOfMessage));
            }
        }

        private static string ChangeLettersCase(string currentFrequency)
        {
            string newfrequency = string.Empty;

            for (int i = 0; i < currentFrequency.Length; i++)
            {
                char character = currentFrequency[i];

                if (char.IsLetter(character))
                {
                    if (char.IsLower(character))
                    {
                        newfrequency += character.ToString().ToUpper();
                    }
                    else if (char.IsUpper(character))
                    {
                        newfrequency += character.ToString().ToLower();
                    }
                }
                else
                {
                    newfrequency += character;
                }
            }

            return newfrequency;
        }
    }
}
