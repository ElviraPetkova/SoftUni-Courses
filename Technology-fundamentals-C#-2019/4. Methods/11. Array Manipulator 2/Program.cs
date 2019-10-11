using System;
using System.Linq;

namespace _11._Array_Manipulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "exchange")
                {
                    int roundNumber = int.Parse(tokens[1]);
                    if (roundNumber < 0 || roundNumber >= arrayFromNumbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    arrayFromNumbers = TurnAndChangeArrayByNumber(arrayFromNumbers, roundNumber);
                }
                else if (command == "max" || command == "min")
                {
                    string typeIndex = tokens[1];

                    switch (typeIndex)
                    {
                        case "even": PrintIndexOfMaxOrMinEvenNumberFromArray(arrayFromNumbers, command); break;

                        case "odd": PrintIndexOfMaxOrMinOddNumberFromArray(arrayFromNumbers, command); break;
                    }

                }
                else if(command == "first" || command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string typeIndex = tokens[2]; // even or odd

                    if (count > arrayFromNumbers.Length) // may be -1?
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if(typeIndex == "even")
                    {
                        PrintFirstOrLastCountEvenNumbersOfArray(count, arrayFromNumbers, command);
                    }
                    else if(typeIndex == "odd")
                    {
                        PrintFirstOrLastCountOddNumbersOfArray(count, arrayFromNumbers, command);
                    }
                }
            }

            Console.WriteLine($"[" + string.Join(", ", arrayFromNumbers) + "]");
        }

        private static void PrintFirstOrLastCountOddNumbersOfArray(int count, int[] arrayFromNumbers, string command)
        {
            var arrFormOddNumbers = arrayFromNumbers.Where(x => x % 2 == 1).ToArray();
            if (arrFormOddNumbers.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                if(count > arrFormOddNumbers.Length)
                {
                    count = arrFormOddNumbers.Length;
                }

                if(command == "first")
                {
                    var firstElements = arrFormOddNumbers.Take(count).ToArray();
                    Console.WriteLine($"[" + string.Join(", ", firstElements) + "]");
                }
                else if(command == "last")
                {
                    var lastElements = arrFormOddNumbers.TakeLast(count).ToArray();
                    Console.WriteLine($"[" + string.Join(", ", lastElements) + "]");
                }
            }
        }

        private static void PrintFirstOrLastCountEvenNumbersOfArray(int count, int[] arrayFromNumbers, string command)
        {
            var arrFormEvenNumbers = arrayFromNumbers.Where(x => x % 2 == 0).ToArray();
            if (arrFormEvenNumbers.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                if(count > arrFormEvenNumbers.Length)
                {
                    count = arrFormEvenNumbers.Length;
                }
                if (command == "first")
                {
                    var firstElements = arrFormEvenNumbers.Take(count).ToArray();
                    Console.WriteLine($"[" + string.Join(", ", firstElements) + "]");
                }
                else
                {
                    var lastElements = arrFormEvenNumbers.TakeLast(count).ToArray();
                    Console.WriteLine($"[" + string.Join(", ", lastElements) + "]");
                }
            }
        }

        private static void PrintIndexOfMaxOrMinOddNumberFromArray(int[] arrayFromNumbers, string command)
        {
            var arrayOddNumbers = arrayFromNumbers.Where(x => x % 2 == 1).ToArray(); //new array, where values are odd
            if(arrayOddNumbers.Length == 0)                                         //if new array is empty => don't have odd number
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int lastIndexOfValue = 0;
                if(command == "max") //if search max odd
                {
                    int maxOddValue = arrayFromNumbers.Where(x => x % 2 == 1).Max();
                    lastIndexOfValue = Array.LastIndexOf(arrayFromNumbers, maxOddValue); //may be more value = maxOdd end we search rightmost
                }
                else if(command == "min") //if search min odd
                {
                    int minOddValue = arrayFromNumbers.Where(x => x % 2 == 1).Min();
                    lastIndexOfValue = Array.LastIndexOf(arrayFromNumbers, minOddValue);
                }

                Console.WriteLine(lastIndexOfValue);
            }
        }

        private static void PrintIndexOfMaxOrMinEvenNumberFromArray(int[] arrayFromNumbers, string command)
        {
            var arrayEvenNumbers = arrayFromNumbers.Where(x => x % 2 == 0).ToArray();
            if (arrayEvenNumbers.Length == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int lastIndexOfValue = 0;
                if (command == "max")
                {
                    int maxEvenValue = arrayFromNumbers.Where(x => x % 2 == 0).Max();
                    lastIndexOfValue = Array.LastIndexOf(arrayFromNumbers, maxEvenValue);
                }
                else if(command == "min")
                {
                    int minEvenValue = arrayFromNumbers.Where(x => x % 2 == 0).Min();
                    lastIndexOfValue = Array.LastIndexOf(arrayFromNumbers, minEvenValue);
                }

                Console.WriteLine(lastIndexOfValue);
            }
            
        }

        private static int[] TurnAndChangeArrayByNumber(int[] arrayFromNumbers, int roundNumber)
        {
            for (int i = 0; i <= roundNumber; i++) //round array n- times
            {
                int firstNumber = arrayFromNumbers[0]; 
                for (int j = 0; j < arrayFromNumbers.Length - 1; j++)
                {
                    arrayFromNumbers[j] = arrayFromNumbers[j + 1]; 
                }
                arrayFromNumbers[arrayFromNumbers.Length - 1] = firstNumber; 
            }

            return arrayFromNumbers;
        }
    }
}
