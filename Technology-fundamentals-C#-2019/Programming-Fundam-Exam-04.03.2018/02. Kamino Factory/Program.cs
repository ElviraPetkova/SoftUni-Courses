using System;
using System.Linq;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfDNA = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[lenghtOfDNA];

            int bestRow = 1;
            int currentRow = 1;

            int bestSum = 0;
            int bestLenght = 0;

            int bestStartIndex = -1;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Clone them!")
                {
                    Console.WriteLine($"Best DNA sample {bestRow} with sum: {bestSum}.");
                    Console.WriteLine(string.Join(" ", bestDNA));
                    break;
                }

                int[] currentDNA = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = currentDNA.Sum();

                if(currentRow == 1)
                {
                    bestDNA = currentDNA;
                    bestRow = currentRow;
                    bestSum = currentSum;
                }

                int currentLenght = 0;
                int currentStartIndex = -1;
                bool isFound = false;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        if (isFound == false)
                        {
                            currentStartIndex = i;
                        }

                        currentLenght++;

                        if (currentLenght > bestLenght)
                        {
                            bestLenght = currentLenght;
                            bestRow = currentRow;
                            bestStartIndex = currentStartIndex;
                            bestSum = currentSum;

                            bestDNA = currentDNA;
                        }
                        else if (currentLenght == bestLenght)
                        {
                            if (currentStartIndex < bestStartIndex)
                            {
                                bestLenght = currentLenght;
                                bestRow = currentRow;
                                bestStartIndex = currentStartIndex;
                                bestSum = currentSum;

                                bestDNA = currentDNA;
                            }
                            else if (currentSum > bestSum)
                            {
                                bestLenght = currentLenght;
                                bestRow = currentRow;
                                bestStartIndex = currentStartIndex;
                                bestSum = currentSum;

                                bestDNA = currentDNA;
                            }
                        }
                    }
                    else if (currentDNA[i] == 0)
                    {
                        currentStartIndex = -1;
                        currentLenght = 0;
                        isFound = false;
                    }
                }

                currentRow++;
            }
        }
    }
}
