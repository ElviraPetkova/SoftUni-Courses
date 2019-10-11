using System;

namespace _005._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            char[] arrayOfChar = new char[count];

            for (int i = 0; i < count; i++)
            {
                string numbers = Console.ReadLine();
                int lenght = numbers.Length;
                int digit = int.Parse(numbers) % 10;

                switch (digit)
                {

                    case 0: arrayOfChar[i] = ' '; break;
                    case 2:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'a'; break;
                            case 2: arrayOfChar[i] = 'b'; break;
                            case 3: arrayOfChar[i] = 'c'; break;
                        }
                        break;
                    case 3:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'd'; break;
                            case 2: arrayOfChar[i] = 'e'; break;
                            case 3: arrayOfChar[i] = 'f'; break;
                        }
                        break;
                    case 4:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'g'; break;
                            case 2: arrayOfChar[i] = 'h'; break;
                            case 3: arrayOfChar[i] = 'i'; break;
                        }
                        break;
                    case 5:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'j'; break;
                            case 2: arrayOfChar[i] = 'k'; break;
                            case 3: arrayOfChar[i] = 'l'; break;
                        }
                        break;
                    case 6:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'm'; break;
                            case 2: arrayOfChar[i] = 'n'; break;
                            case 3: arrayOfChar[i] = 'o'; break;
                        }
                        break;
                    case 7:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'p'; break;
                            case 2: arrayOfChar[i] = 'q'; break;
                            case 3: arrayOfChar[i] = 'r'; break;
                            case 4: arrayOfChar[i] = 's'; break;
                        }
                        break;
                    case 8:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 't'; break;
                            case 2: arrayOfChar[i] = 'u'; break;
                            case 3: arrayOfChar[i] = 'v'; break;
                        }
                        break;
                    case 9:
                        switch (lenght)
                        {
                            case 1: arrayOfChar[i] = 'w'; break;
                            case 2: arrayOfChar[i] = 'x'; break;
                            case 3: arrayOfChar[i] = 'y'; break;
                            case 4: arrayOfChar[i] = 'z'; break;
                        }
                        break;
                }
            }

            arrayOfChar.ToString();
            Console.WriteLine(arrayOfChar);
        }
    }
}
