using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string pattern = @"@([A-Za-z]+)[^@|\-|!|:|>]*!([G])!";
            Regex regex = new Regex(pattern);

            List<string> listOfGoodChildrens = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string decryptionString = DecryptingString(input, key);

                if (regex.IsMatch(decryptionString))
                {
                    Match matchChildren = regex.Match(decryptionString);
                    string nameOfKid = matchChildren.Groups[1].Value;

                    if(listOfGoodChildrens.Contains(nameOfKid) == false)
                    {
                        listOfGoodChildrens.Add(nameOfKid);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfGoodChildrens));
        }

        private static string DecryptingString(string input, int key)
        {
            string decryption = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char oldCharacter = input[i];
                char newCharacter = (char)(oldCharacter - key);
                decryption += newCharacter;
            }

            return decryption;
        }
    }
}
