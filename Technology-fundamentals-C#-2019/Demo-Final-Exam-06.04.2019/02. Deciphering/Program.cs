using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedString = Console.ReadLine();
            var words = Console.ReadLine().Split();
            string firstWord = words[0];
            string replacedWord = words[1];

            bool validString = ValidationString(encryptedString);

            if(validString == false)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            string decripted = DecriptingString(encryptedString);

            while (decripted.Contains(firstWord))
            {
                decripted = decripted.Replace(firstWord, replacedWord);
            }

            Console.WriteLine(decripted);


        }

        private static bool ValidationString(string text)
        {
            string pattern = @"^[d-z#|\{\}]+$";
            Regex regex = new Regex(pattern);

            bool valid = false;

            if (regex.IsMatch(text))
            {
                valid = true;
            }

            return valid;
        }

        private static string DecriptingString(string encryptedString)
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < encryptedString.Length; i++)
            {
                resultString.Append((char)(encryptedString[i] - 3));
            }

            return resultString.ToString();
        }
    }
}
