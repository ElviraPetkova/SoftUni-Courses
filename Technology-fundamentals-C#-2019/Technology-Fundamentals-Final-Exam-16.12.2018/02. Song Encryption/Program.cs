using System;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternPerArtist = @"^[A-Z][a-z]+[ |a-z| ']*$";
            Regex regexPerArtist = new Regex(patternPerArtist);

            string patternPerSong = @"^[A-Z]+[ |A-Z]*$";
            Regex regexPerSong = new Regex(patternPerSong);

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(':');
                string artist = tokens[0];
                string song = tokens[1];

                if(regexPerArtist.IsMatch(artist) && regexPerSong.IsMatch(song))
                {
                    //Match matchArtist = regexPerArtist.Match(artist);
                    //Match matchSong = regexPerSong.Match(song);

                    int key = artist.Length;
                    DecriptInput(input, key);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void DecriptInput(string input, int key)
        {
            string decriptString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char oldCharacter = input[i];
                if(oldCharacter == ' ')
                {
                    decriptString += oldCharacter;
                }
                else if(oldCharacter == ':')
                {
                    decriptString += '@';
                }
                else if(oldCharacter == 39)
                {
                    decriptString += (char)39;
                }
                else
                {
                    if(oldCharacter >=65 && oldCharacter <= 90)
                    {
                        if(oldCharacter + key <= 90)
                        {
                            decriptString += (char)(oldCharacter + key);
                        }
                        else
                        {
                            int newChar = oldCharacter + key;

                            while (newChar > 90)
                            {
                                int diff = newChar - 90;
                                newChar = 64 + diff;
                            }

                            decriptString += (char)(newChar);
                        }
                    }
                    else if(oldCharacter >= 97 && oldCharacter <= 122)
                    {
                        if (oldCharacter + key <= 122)
                        {
                            decriptString += (char)(oldCharacter + key);
                        }
                        else
                        {
                            int newChar = oldCharacter + key;

                            while (newChar > 122)
                            {
                                int diff = newChar - 122;
                                newChar = 96 + diff;
                            }

                            decriptString += (char)(newChar);
                        }
                    }
                }
            }

            Console.WriteLine($"Successful encryption: {decriptString}");
        }
    }
}
