using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1._Messaging
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string someText = Console.ReadLine();

            List<char> text = someText.ToList(); 

            string mess = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int sumOfDigits = GetSumOfDigitsOfOneNumber(numbers[i]);
                
                if(sumOfDigits <= text.Count - 1)
                {
                    mess += text[sumOfDigits];
                    text.RemoveAt(sumOfDigits);
                }
                else
                {
                    int index = sumOfDigits % text.Count;
                    mess += text[index];
                    text.RemoveAt(index);
                }
            }

            Console.WriteLine(mess);
        }

        static int GetSumOfDigitsOfOneNumber(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}
