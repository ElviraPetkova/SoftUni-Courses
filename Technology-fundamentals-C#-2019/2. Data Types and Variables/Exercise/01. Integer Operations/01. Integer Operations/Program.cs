using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fordNumber = int.Parse(Console.ReadLine());

            int sumFromFirstTwoNumbers = firstNumber + secondNumber;
            int divideFromSum = sumFromFirstTwoNumbers / thirdNumber;
            int product = divideFromSum * fordNumber;

            Console.WriteLine(product);
        }
    }
}
