using System;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        public static void Main(string[] args)
        {
            string typeValue = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            Console.WriteLine(GetMax(typeValue, firstValue, secondValue));
        }

        public static string GetMax(string type, string firstValue, string secondValue)
        {
            string maxValue = string.Empty;
            switch (type)
            {
                case "int":
                    int firstNum = int.Parse(firstValue);
                    int secondNum = int.Parse(secondValue);
                    int max = Math.Max(firstNum, secondNum);
                    maxValue = max + "";
                    break;
                case "char":
                    char firstChar = char.Parse(firstValue);
                    char secondChar = char.Parse(secondValue);
                    int maxChar = (int)Math.Max(firstChar, secondChar);
                    maxValue = (char)maxChar + "";
                    break;
                case "string":
                    int diff = firstValue.CompareTo(secondValue);
                    if(diff > 0)
                    {
                        maxValue = firstValue;
                    }
                    else
                    {
                        maxValue = secondValue;
                    }
                    break;

            }

            return maxValue;
        }
    }
}
