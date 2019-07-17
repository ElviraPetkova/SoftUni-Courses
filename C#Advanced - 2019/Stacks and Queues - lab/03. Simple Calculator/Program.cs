using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackPerCalculator = new Stack<string>(Console.ReadLine().Split().Reverse());

            while (stackPerCalculator.Count != 1)
            {
                string item = stackPerCalculator.Pop();
                if (item != "+" || item != "-")
                {
                    int firstNumber = int.Parse(item);

                    string symbol = stackPerCalculator.Pop();

                    string currentItem = stackPerCalculator.Pop();
                    int secondNumber = int.Parse(currentItem);

                    if (symbol == "+")
                    {
                        int currentNumber = firstNumber + secondNumber;
                        stackPerCalculator.Push(currentNumber.ToString());
                    }
                    else if (symbol == "-")
                    {
                        int currentNumber = firstNumber - secondNumber;
                        stackPerCalculator.Push(currentNumber.ToString());
                    }
                }
            }

            Console.WriteLine(stackPerCalculator.Pop());
        }
    }
}
