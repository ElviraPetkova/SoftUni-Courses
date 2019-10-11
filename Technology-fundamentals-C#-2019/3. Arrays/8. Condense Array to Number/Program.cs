using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lenght = arrayFromNum.Length;

            while(lenght > 1)
            {
                for (int i = 0; i < arrayFromNum.Length - 1; i++)
                {
                    int firstNum = arrayFromNum[i];
                    int nextNum = arrayFromNum[i + 1];
                    arrayFromNum[i] = firstNum + nextNum;
                }

                Array.Resize(ref arrayFromNum, lenght - 1);

                lenght--;
            }

            Console.WriteLine(string.Join(" ", arrayFromNum));
        }
    }
}
