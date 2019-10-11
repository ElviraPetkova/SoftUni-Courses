using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            ListyIterator<string> listyIterator = null;

            while (true)
            {
                string input = Console.ReadLine();
                var splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = splitedInput[0];

                if(command == "Create")
                {
                    listyIterator = new ListyIterator<string>(splitedInput.Skip(1).ToArray());
                }
                else if(command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch(InvalidOperationException invalidOperation)
                    {
                        Console.WriteLine(invalidOperation.Message);
                    }
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if(command == "PrintAll")
                {
                    try
                    {
                        listyIterator.PrintAll();
                    }
                    catch(InvalidOperationException invalidOperation)
                    {
                        Console.WriteLine(invalidOperation.Message);
                    }
                }
                else if (command == "END")
                {
                    break;
                }
                //else
                //{
                //    throw new ArgumentException();
                //}
            }
        }
    }
}
