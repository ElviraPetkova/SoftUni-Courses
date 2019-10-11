using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ").ToArray();

            List<string> validUserNames = new List<string>();

            for (int i = 0; i < userNames.Length; i++)
            {
                string name = userNames[i];
                bool isValidName = ChekingName(name);
                AddValidNameInList(isValidName, name, validUserNames);
            }

            PrintValidNAmes(validUserNames);
        }

        private static void PrintValidNAmes(List<string> validUserNames)
        {
            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }

        private static void AddValidNameInList(bool isValidName, string name, List<string> validUserNames)
        {
            if (isValidName)
            {
                validUserNames.Add(name);
            }
        }

        private static bool ChekingName(string name)
        {
            bool lenghtOfName = ChekingLenght(name);
            bool contentName = ChekingContent(name);

            bool validName = false;
            if (lenghtOfName && contentName)
            {
                validName = true;
            }

            return validName;
        }

        private static bool ChekingContent(string name)
        {
            //Contains only letters, numbers, hyphens and underscores

            bool content = true;

            for (int i = 0; i < name.Length; i++)
            {
                char oneChar = name[i];
                if (char.IsLetterOrDigit(oneChar) || oneChar == '-' || oneChar == '_')
                {
                    content = true;
                }
                else
                {
                    content = false;
                    break;
                }
            }

            return content;
        }

        private static bool ChekingLenght(string name)
        {
            bool lenght = false;
            if (name.Length >= 3 && name.Length <= 16)
            {
                lenght = true;
            }

            return lenght;
        }
    }
}
