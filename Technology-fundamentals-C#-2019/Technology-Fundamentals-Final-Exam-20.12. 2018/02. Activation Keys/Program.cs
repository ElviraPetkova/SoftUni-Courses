using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine().Split('&');

            List<string> buttons = new List<string>();

            for (int i = 0; i < keys.Length; i++)
            {
                string oneButton = keys[i];
                bool valid = ValidationingKeys(oneButton);

                if (valid == false)
                {
                    continue;
                }

                string currentButton = FixNewButton(oneButton);
                string resultButton = ChangeDigitsInButton(currentButton);
                buttons.Add(resultButton);
            }

            Console.WriteLine(string.Join(", ", buttons));
        }

        private static string ChangeDigitsInButton(string currentButton)
        {
            string newButton = string.Empty;

            for (int i = 0; i < currentButton.Length; i++)
            {
                if(char.IsLetter(currentButton[i]))
                {
                    newButton += currentButton[i].ToString().ToUpper();
                }
                else if(char.IsDigit(currentButton[i]))
                {
                    int oldDigit = int.Parse(currentButton[i].ToString());
                    int newDigit = 9 - oldDigit;
                    newButton += newDigit;
                }
                else
                {
                    newButton += currentButton[i];
                }
            }

            return newButton.TrimEnd('-');

        }

        private static string FixNewButton(string oneButton)
        {
            string newButton = string.Empty;
            if (oneButton.Length == 16)
            {
                int index = 0;
                for (int i = 0; i < 4; i++)
                {
                    string currentString = oneButton.Substring(index, 4);
                    index += 4;
                    newButton += currentString;
                    newButton += '-';
                }
            }
            else if(oneButton.Length == 25)
            {
                int index = 0;
                for (int i = 0; i < 5; i++)
                {
                    string currentString = oneButton.Substring(index, 5);
                    index += 5;
                    newButton += currentString;
                    newButton += '-';
                }
            }

            return newButton;
        }

        private static bool ValidationingKeys(string oneButton)
        {
            bool validLenght = false;
            if (oneButton.Length == 16 || oneButton.Length == 25)
            {
                validLenght = true;
            }

            string pattern = @"^[A-Za-z0-9]+$";
            Regex regex = new Regex(pattern);

            bool validContent = false;
            if (regex.IsMatch(oneButton))
            {
                validContent = true;
            }

            bool validKey = false;
            if(validLenght && validContent)
            {
                validKey = true;
            }

            return validKey;
        }
    }
}
