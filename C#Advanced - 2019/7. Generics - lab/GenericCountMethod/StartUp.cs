using System;
using System.Collections.Generic;

namespace GenericCountMethod
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfLine = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < countOfLine; i++)
            {
                double line = double.Parse(Console.ReadLine());
                box.Add(line);
            }

            double value = double.Parse(Console.ReadLine());

            int count = GetCountOgGreaterElement(box.Data, value);
            Console.WriteLine(count);

        }

        public static int GetCountOgGreaterElement<T>(List<T> listOfData, T value)
            where T : IComparable
        {
            int count = 0;

            foreach (var item in listOfData) //-1 < ; 0 =; 1 >
            {
                if(item.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
