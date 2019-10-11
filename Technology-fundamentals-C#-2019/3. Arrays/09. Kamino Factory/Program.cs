using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfDNA = int.Parse(Console.ReadLine());

            int lenght = 0;
            int sum = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;

            int[] bestDNA = new int[lenghtOfDNA];

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }

                int[] DNA = line
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = 0;

                for (int i = 0; i < DNA.Length; i++)
                {
                    if (DNA[i] == 1)
                    {
                        currentSum++;
                    }
                }

                if (currentRow == 1)
                {
                    bestDNA = DNA;
                    row = currentRow;
                    sum = currentSum;
                }

                int currentStartIndex = -1;
                int currentLenght = 0;
                bool isFound = false;

                for (int i = 0; i < DNA.Length; i++)
                {
                    if (DNA[i] == 1)
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }

                        currentLenght++;

                        if (currentLenght > lenght)
                        {
                            lenght = currentLenght;
                            startIndex = currentStartIndex;
                            sum = currentSum;
                            row = currentRow;

                            bestDNA = DNA;
                        }
                        else if (currentLenght == lenght)
                        {
                            if (currentStartIndex < startIndex)
                            {
                                lenght = currentLenght;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;

                                bestDNA = DNA;
                            }
                            else if (currentSum > sum)
                            {
                                lenght = currentLenght;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;

                                bestDNA = DNA;
                            }
                        }
                    }
                    else
                    {
                        currentStartIndex = -1;
                        currentLenght = 0;
                        isFound = false;
                    }
                }

                currentRow++;

            }

            Console.WriteLine("Best DNA sample {0} with sum: {1}.", row, sum);
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
