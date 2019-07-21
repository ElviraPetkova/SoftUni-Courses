using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchNameLenght = int.Parse(Console.ReadLine());

            //Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(x => x.Length <= searchNameLenght)
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            Func<string, bool> anotherFunc = x => x.Length <= searchNameLenght;
            Func<List<string>, List<string>> funcByLenghtName = x => x.Where(anotherFunc).ToList();
            Action<List<string>> printList = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            var listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            listOfNames = funcByLenghtName(listOfNames);
            printList(listOfNames);
        }
    }
}
