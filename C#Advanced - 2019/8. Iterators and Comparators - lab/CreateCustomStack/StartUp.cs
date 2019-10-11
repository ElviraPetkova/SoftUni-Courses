using System;
using System.Linq;

namespace CreateCustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            while (true)
            {
                string input = Console.ReadLine();
                var splitedInput = input
                    .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                string command = splitedInput[0];

                if(command == "Push")
                {
                    
                    customStack.Push(splitedInput
                                             .Skip(1)
                                             .Select(int.Parse)
                                             .ToArray());

                }
                else if(command == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch(InvalidOperationException invalidOperation)
                    {
                        Console.WriteLine(invalidOperation.Message);
                    }
                }
                else if(command == "END")
                {
                    customStack.Print();
                    break;
                }
            }
        }
    }
}
