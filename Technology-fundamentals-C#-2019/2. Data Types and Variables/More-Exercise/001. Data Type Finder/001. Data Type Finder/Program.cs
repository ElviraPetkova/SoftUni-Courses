using System;

namespace _001._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolean;
            int integer;
            double floatPoint;
            char character;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                bool isInteger = int.TryParse(line, out integer);
                bool isDouble = double.TryParse(line, out floatPoint);
                bool isChar = char.TryParse(line, out character);
                bool isBoolean = bool.TryParse(line, out boolean);

                if (isInteger)
                {
                    Console.WriteLine("{0} is integer type", integer);
                }
                else if (isDouble)
                {
                    Console.WriteLine("{0} is floating point type", line);
                }
                else if (isChar)
                {
                    Console.WriteLine("{0} is character type", character);
                }
                else if (isBoolean)
                {
                    Console.WriteLine("{0} is boolean type", line);
                }
                else
                {
                    Console.WriteLine("{0} is string type", line);
                }

            }
        }
    }
}
