using System;
using System.Collections.Generic;
using System.Linq;

namespace Excel_Functions
{
    public class Program
    {
        public static void Main()
        {
            int countOfLine = int.Parse(Console.ReadLine());

            string[][] excelTable = new string[countOfLine][];

            for (int i = 0; i < countOfLine; i++)
            {
                string[] currentRow = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                excelTable[i] = currentRow;
            }

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = input[0];
            string header = input[1];

            int headerIndex = Array.IndexOf(excelTable[0], header);

            switch (command)
            {
                case "hide":
                    PrintMatrixWithoutOneCol(excelTable, headerIndex);
                    break;
                case "sort":
                    PrintSortedMatrixByHeader(excelTable, header, headerIndex);
                    break;
                case "filter":
                    string filter = input[2];
                    PrintPrintFilerRow(excelTable, headerIndex, filter);
                    break;

            }
    
        }

        private static void PrintPrintFilerRow(string[][] excelTable, int headerIndex, string filter)
        {
            Console.WriteLine(string.Join(" | ", excelTable[0]));

            for (int row = 0; row < excelTable.Length; row++)
            {
                if(excelTable[row][headerIndex] == filter)
                {
                    Console.WriteLine(string.Join(" | ", excelTable[row]));
                }
            }
        }

        private static void PrintSortedMatrixByHeader(string[][] excelTable,string header, int headerIndex)
        {
            var headerRow = excelTable[0];
            Console.WriteLine(string.Join(" | ", headerRow));

            excelTable = excelTable.OrderBy(x => x[headerIndex]).ToArray();

            foreach (var row in excelTable)
            {
                if(row != headerRow)
                {
                    Console.WriteLine(string.Join(" | ", row));
                }
            }
        }

        private static void PrintMatrixWithoutOneCol(string[][] excelTable, int headerIndex)
        {
            for (int row = 0; row < excelTable.Length; row++)
            {
                List<string> lineToPrint = new List<string>();

                lineToPrint.AddRange(excelTable[row].Take(headerIndex).ToList());
                lineToPrint.AddRange(excelTable[row].Skip(headerIndex + 1));

                Console.WriteLine(string.Join(" | ", lineToPrint));        
            }

        }

        private static void RemovedOneCol(string[][] excelTable, int headerIndex)
        {
            for (int row = 0; row < excelTable.Length; row++)
            {
                List<string> currentRow = new List<string>(excelTable[row]);
                currentRow.RemoveAt(headerIndex);

                excelTable[row] = currentRow.ToArray();
            }
        }
    }
}
