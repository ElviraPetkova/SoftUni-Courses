using System;
using System.Linq;

namespace _02._Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", arrayOfStrings)}]");
                    break;
                }

                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if(command == "reverse")
                {
                    //•	"reverse from [start] count [count]" 
                    //– this instructs you to reverse a portion of the array – just [count] elements starting at index [start];

                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if(startIndex < 0 || startIndex > arrayOfStrings.Length - 1 || 
                        count < 0 || count > arrayOfStrings.Length || startIndex + count > arrayOfStrings.Length)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    Array.Reverse(arrayOfStrings, startIndex, count); //=> Linq
                    //ReverseArray(arrayOfStrings, startIndex, count); => my method

                }
                else if(command == "sort")
                {
                    //•	"sort from [start] count [count]" 
                    //– this instructs you to sort a portion of the array - [count] elements starting at index [start];

                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (startIndex < 0 || startIndex > arrayOfStrings.Length - 1 || 
                        count < 0 || count > arrayOfStrings.Length || startIndex + count > arrayOfStrings.Length)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    Array.Sort(arrayOfStrings, startIndex, count);

                }
                else if(command == "rollLeft")
                {
                    //•	"rollLeft [count] times" 
                    //this instructs you to move all elements in the array to the left [count] times. 
                    //On each roll, the first element is placed at the end of the array;

                    int count = int.Parse(tokens[1]);

                    if(count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    RollLeftArray(arrayOfStrings, count);
                }
                else if(command == "rollRight")
                {
                    //•	"rollRight [count] times" 
                    //this instructs you to move all elements in the array to the right [count] times. 
                    //On each roll, the last element is placed at the beginning of the array;

                    int count = int.Parse(tokens[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    RollRightArray(arrayOfStrings, count);
                }
            }
        }

        private static void RollRightArray(string[] arrayOfStrings, int count)
        {
            //lastElement = array[0];

            for (int i = 0; i < count; i++)
            {
                string lastElement = arrayOfStrings[arrayOfStrings.Length - 1];
                for (int j = arrayOfStrings.Length - 1; j > 0; j--)
                {
                    arrayOfStrings[j] = arrayOfStrings[j - 1];
                }
                arrayOfStrings[0] = lastElement;
            }
        }

        private static void RollLeftArray(string[] arrayOfStrings, int count)
        {
            //firstElement = array[array.Lenght - 1];

            for (int i = 0; i < count; i++)
            {
                string firstElement = arrayOfStrings[0];
                for (int j = 0; j < arrayOfStrings.Length - 1; j++)
                {
                    arrayOfStrings[j] = arrayOfStrings[j + 1];
                }
                arrayOfStrings[arrayOfStrings.Length - 1] = firstElement;
            }
        }

        private static void ReverseArray(string[] seriesOfStrings, int index, int count)
        {
            var newArray = new string[count];
            for (int i = index; i < count + index; i++)
            {
                string text = seriesOfStrings[i];
                newArray[Math.Abs((index + count) - i - count)] = text;
            }

            for (int i = 0; i < newArray.Length / 2; i++)
            {
                string first = newArray[i];
                string last = newArray[newArray.Length - i - 1];

                newArray[i] = last;
                newArray[newArray.Length - i - 1] = first;
            }

            for (int i = index; i < count + index; i++)
            {
                string text = newArray[Math.Abs((index + count) - i - count)];
                seriesOfStrings[i] = text;
            }
        }
    }
}
