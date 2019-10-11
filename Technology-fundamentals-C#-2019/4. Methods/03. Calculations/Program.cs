using System;

namespace _03.Calculations
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch(command)
            {
                case "add": PrintAdd(firstNum, secondNum); break;
                case "subtract": PrintSubtract(firstNum, secondNum); break;
                case "multiply": PrintMultiply(firstNum, secondNum); break;
                case "divide": PrintDivide(firstNum, secondNum); break;
            }
        }

        public static void PrintAdd(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine(sum);
        }

        public static void PrintSubtract(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            Console.WriteLine(result);
        }

        public static void PrintMultiply(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }

        public static void PrintDivide(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            Console.WriteLine(result);
        }
    }
}
