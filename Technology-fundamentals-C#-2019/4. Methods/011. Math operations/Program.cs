using System;

namespace _011.Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char typeOperation = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(MathOperation(firstNum, typeOperation, secondNum));
        }

        public static double MathOperation(int firstNumber, char typeOperation, int secondNumber)
        {
            double mathResult = 0;

            switch (typeOperation)
            {
                case '+': mathResult = firstNumber + secondNumber; break;
                case '-': mathResult = firstNumber - secondNumber; break;
                case '*': mathResult = firstNumber * secondNumber; break;
                case '/': mathResult = firstNumber /secondNumber; break;
            }

            return mathResult;
        }
    }
}
