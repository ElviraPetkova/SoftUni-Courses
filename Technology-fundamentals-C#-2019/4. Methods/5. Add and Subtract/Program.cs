using System;

namespace _5.Add_and_Subtract
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);
            Console.WriteLine(Subtract(sum, thirdNum));
        }

        public static int Sum(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static int Subtract(int sum, int thirdNumber)
        {
            int result = sum - thirdNumber;
            return result;
        }
    }
}
