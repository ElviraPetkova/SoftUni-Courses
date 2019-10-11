using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04._Anonymous_Cache
{
    class DataSet
    {
        public string Key { get; set; }

        public long Size { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var validDataSet = new Dictionary<string, List<DataSet>>();
            var keshDataSet = new Dictionary<string, List<DataSet>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "thetinggoesskrra")
                {
                    break;
                }

                var tokens = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if(tokens.Length == 1)
                {
                    string dataSet = tokens[0];
                    if(validDataSet.ContainsKey(dataSet) == false)
                    {
                        validDataSet.Add(dataSet, new List<DataSet>());

                        if (keshDataSet.ContainsKey(dataSet))
                        {
                            var infoFromThisDataSet = keshDataSet[dataSet].ToList();
                            validDataSet[dataSet].AddRange(infoFromThisDataSet);
                        }
                    }
                }
                else
                {
                    string dataKey = tokens[0];
                    long size = long.Parse(tokens[1]);
                    string dataSet = tokens[2];

                    DataSet currentDataSet = new DataSet()
                    {
                        Key = dataKey,
                        Size = size
                    };

                    if (validDataSet.ContainsKey(dataSet))
                    {
                        validDataSet[dataSet].Add(currentDataSet);
                    }
                    else
                    {
                        if(keshDataSet.ContainsKey(dataSet) == false)
                        {
                            keshDataSet.Add(dataSet, new List<DataSet>());
                        }
                        keshDataSet[dataSet].Add(currentDataSet);
                    }
                }
            }

            string maxSumOfSizeNameData = SearchingMaxSumOfSizeAndReturnDataName(validDataSet);
            if(maxSumOfSizeNameData != string.Empty)
            {
                var selectData = validDataSet[maxSumOfSizeNameData].ToList();

                Console.WriteLine($"Data Set: {maxSumOfSizeNameData}, Total Size: {selectData.Sum(x=>x.Size)}");
                foreach (var data in selectData)
                {
                    Console.WriteLine($"$.{data.Key}");
                }
            }
        }

        private static string SearchingMaxSumOfSizeAndReturnDataName(Dictionary<string, List<DataSet>> validDataSet)
        {
            string nameDataSet = string.Empty;
            BigInteger maxSize = 0;
            foreach (var kvp in validDataSet)
            {
                string currentNameData = kvp.Key;
                BigInteger sumOfSize = kvp.Value.Sum(x => x.Size);

                if(maxSize < sumOfSize)
                {
                    maxSize = sumOfSize;
                    nameDataSet = currentNameData;
                }
            }

            return nameDataSet;
        }
    }
}
