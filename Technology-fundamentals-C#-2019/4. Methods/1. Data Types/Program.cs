using System;

namespace _1.Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();
            PrintResult(dataType, value);
        }

        private static void PrintResult(string dataType, string value)
        {
            switch(dataType)
            {
                case "int": int number = int.Parse(value);
                    int multiply = number * 2;
                    Console.WriteLine(multiply);
                    break;
                case "real": double numberReal = double.Parse(value);
                    double multiplyReal = numberReal * 1.5;
                    Console.WriteLine($"{multiplyReal:f2}");
                    break;
                case "string": Console.WriteLine($"${value}$"); break;
            }
        }
    }
}
