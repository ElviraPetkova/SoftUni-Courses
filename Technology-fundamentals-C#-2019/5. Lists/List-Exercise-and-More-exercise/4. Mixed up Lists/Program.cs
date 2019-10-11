using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int startRange = 0;
            int endRange = 0;

            secondList.Reverse();

            if (firstList.Count > secondList.Count)
            {
                startRange = firstList[firstList.Count - 2];
                endRange = firstList[firstList.Count - 1];
                firstList.RemoveAt(firstList.Count - 2);
                firstList.RemoveAt(firstList.Count - 1);
            }
            else
            {
                startRange = secondList[secondList.Count - 2];
                endRange = secondList[secondList.Count - 1];
                secondList.RemoveAt(secondList.Count - 2);
                secondList.RemoveAt(secondList.Count - 1);
            }

            List<int> mergeList = MergingTwoList(firstList, secondList);

            mergeList = ModificationByBetwenTwoNumbers(mergeList, startRange, endRange);

            mergeList.Sort();

            Console.WriteLine(string.Join(" ", mergeList));
        }

        private static List<int> ModificationByBetwenTwoNumbers(List<int> mergeList, int startRange, int endRange)
        {
            int minNum = Math.Min(startRange, endRange);
            int maxNum = Math.Max(startRange, endRange);

            List<int> modificationNumbers = new List<int>();

            for (int i = 0; i < mergeList.Count; i++)
            {
                int numberFromList = mergeList[i];
                if (numberFromList > minNum && numberFromList < maxNum)
                {
                    modificationNumbers.Add(numberFromList);
                }
            }

            return modificationNumbers;
        }

        private static List<int> MergingTwoList(List<int> firstList, List<int> secondList)
        {
            List<int> mergeList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                mergeList.Add(firstList[i]);
                mergeList.Add(secondList[i]);
            }

            return mergeList;
        }
    }
}
