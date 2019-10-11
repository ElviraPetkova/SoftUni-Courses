using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumber = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    Console.WriteLine(string.Join(" ", listOfNumber));
                    break;
                }

                string[] tokens = input.Split();

                /*  -	Change {paintingNumber} {changedNumber} – find the painting with the first number in the collection (if it exists) 
                 *  and change its number with the second number – {changedNumber}.
                    -	Hide {paintingNumber} – find the painting with this value and if it exists and hide it (remove it).
                    -	Switch {paintingNumber} {paintingNumber2} – find the given paintings in the collections if they exist and switch their places.
                    -	Insert {place} {paintingNumber} – insert the painting (paintingNumber) on the next place after the given one, if it exists.
                    -	Reverse – you must reverse the order of the paintings. */

                string command = tokens[0];
                if(command == "Change")
                {
                    int paintNumber = int.Parse(tokens[1]);
                    int changeNumber = int.Parse(tokens[2]);

                    if (listOfNumber.Contains(paintNumber))
                    {
                        int index = listOfNumber.IndexOf(paintNumber);
                        listOfNumber[index] = changeNumber;
                    }
                }
                else if(command == "Hide")
                {
                    int paintNumber = int.Parse(tokens[1]);
                    if (listOfNumber.Contains(paintNumber))
                    {
                        listOfNumber.Remove(paintNumber); //may be index
                    }
                }
                else if(command == "Switch")
                {
                    int firstPaintNumber = int.Parse(tokens[1]);
                    int secondPaintNumber = int.Parse(tokens[2]);

                    if(listOfNumber.Contains(firstPaintNumber) && listOfNumber.Contains(secondPaintNumber))
                    {
                        int indexFirst = listOfNumber.IndexOf(firstPaintNumber);
                        int indexSecond = listOfNumber.IndexOf(secondPaintNumber);

                        listOfNumber[indexFirst] = secondPaintNumber;
                        listOfNumber[indexSecond] = firstPaintNumber;
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);

                    if(index >= 0 && index < listOfNumber.Count)
                    {
                        listOfNumber.Insert(index + 1, value);
                    }
                }
                else if (command == "Reverse")
                {
                    listOfNumber.Reverse();
                }

            }
        }
    }
}
