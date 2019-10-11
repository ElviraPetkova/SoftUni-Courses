using System;

namespace _1._Implement_the_CustomList_class
{
    public class StartUp
    {
        public static void Main()
        {
            DoublyLinkedList<int> myList = new DoublyLinkedList<int>();
            myList.AddLast(5);
            myList.AddLast(15);
            myList.AddLast(30);
            myList.AddLast(100);
            myList.AddLast(200);
            myList.AddLast(300);
            Console.WriteLine(myList.Count);
            myList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(myList.RemoveLast());
            var array = myList.ToArray();
            Console.WriteLine(string.Join(" ", array));

            CustomList<int> currentList = new CustomList<int>();
            currentList.Add(8);
            currentList.Add(10);
            currentList.Add(30);
            currentList.Add(40);
            currentList.Add(50);
            currentList.RemoveAt(2);
            currentList.Insert(2, 100);
            Console.WriteLine(currentList.Count);
            Console.WriteLine(currentList.Contains(5));
            Console.WriteLine(currentList.Contains(30));
            int[] numbers = new int[] { 200, 250, 23, 75 };
            currentList.AddRange(numbers);
            Console.WriteLine(currentList.Count);
            Console.WriteLine(currentList.IndexOf(250));
            Console.WriteLine(currentList.IndexOf(1));
            Console.WriteLine(currentList.Remove(120));
            Console.WriteLine(currentList.Remove(200));
            Console.WriteLine(currentList.Count);
            currentList.Add(100);
            currentList.Add(100);
            currentList.Add(100);
            currentList.Add(100);
            Console.WriteLine(currentList.Count);
            currentList.RemoveAll(100);
            Console.WriteLine(currentList.Count);
            Console.WriteLine(string.Join(",", currentList));
            currentList.Swap(2, 5);
            Console.WriteLine(string.Join(",", currentList));
            


            CustomList<string> stringList = new CustomList<string>();
            stringList.Add("Maria");
            stringList.Add("Ivan");
            stringList.Add("Georgi");
            stringList.RemoveAt(0);
            stringList.Insert(1, "100");
            Console.WriteLine();
            Console.WriteLine(stringList.Count);
            Console.WriteLine(stringList.Contains("Georgi"));
            Console.WriteLine(stringList.Contains("Maria"));
            string[] someStrings = new string[] { "Pesho", "Kalin", "Viktoria" };
            stringList.AddRange(someStrings);
            Console.WriteLine(stringList.Count);
            Console.WriteLine(stringList.IndexOf("Pesho"));
            Console.WriteLine(stringList.IndexOf("Elena"));
            Console.WriteLine(stringList.Remove("100"));
            Console.WriteLine(stringList.Remove("100"));
            Console.WriteLine(stringList.Count);
            Console.WriteLine(string.Join(", ", stringList));
            Console.WriteLine();

            CustomStack<string> stackFromInt = new CustomStack<string>();
            stackFromInt.Push("Hello");
            stackFromInt.Push("Mimi");
            stackFromInt.Push("Hi");
            stackFromInt.Push("Zdr");
            stackFromInt.Push("Validation");
            Console.WriteLine(stackFromInt.Count);
            Console.WriteLine();
            Console.WriteLine(stackFromInt.Pop());
            Console.WriteLine(stackFromInt.Count);
            Console.WriteLine(stackFromInt.Peek());
            Console.WriteLine();
            stackFromInt.ForEach(x => Console.WriteLine(x));
        }
    }
}
