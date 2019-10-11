using System;
using System.Linq;

namespace _05.__Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int digit = int.Parse(Console.ReadLine());

            if(firstNumber == "0" || digit == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string newNumber = string.Empty;
            int residue = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(firstNumber[i].ToString());
                int multiply = lastDigit * digit;

                if(residue > 0)
                {
                    multiply += residue;
                    residue = 0;
                }

                if(multiply > 9)
                {
                    while (multiply > 9)
                    {
                        residue += multiply / 10;
                        multiply %= 10;
                    }
                }

                newNumber += multiply.ToString();
                if(i == 0 && residue > 0)
                {
                    newNumber += residue.ToString();
                }
            }

            char[] product = newNumber.ToArray().Reverse().ToArray();
            Console.WriteLine(string.Join(string.Empty, product));
        }
    }
}
