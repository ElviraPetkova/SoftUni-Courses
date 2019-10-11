using System;

namespace _4.Password_Validator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PrintPasswordValidator(password);
        }

        public static void PrintPasswordValidator(string password)
        {
            if (CorrectLenght(password) && CorrectContent(password) && CorrectDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CorrectLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!CorrectContent(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!CorrectDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        public static bool CorrectLenght(string password)
        {
            int lenght = password.Length;
            bool isCorrectLenght = true;
            if (lenght < 6 || lenght > 10)
            {
                isCorrectLenght = false;
            }

            return isCorrectLenght;
        }

        public static bool CorrectContent(string password)
        {
            int otherSymbols = 0;
            bool onlyLettersAndDigits = true;

            for (int countOfWord = 0; countOfWord < password.Length; countOfWord++)
            {
                if (!(password[countOfWord] >= 'A' && password[countOfWord] <= 'Z')
                     && !(password[countOfWord] >= 'a' && password[countOfWord] <= 'z')
                     && !(password[countOfWord] >= '0' && password[countOfWord] <= '9'))
                {
                    otherSymbols++;
                }
            }

            if (otherSymbols > 0)
            {
                onlyLettersAndDigits = false;
            }

            return onlyLettersAndDigits;
        }

        public static bool CorrectDigits(string password)
        {
            int countOfDigits = 0;
            bool twoDigits = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    countOfDigits++;
                }
            }

            if (countOfDigits < 2)
            {
                twoDigits = false;
            }

            return twoDigits;
        }
    }
}
