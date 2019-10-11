using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int content = int.Parse(Console.ReadLine());
                Box<int> boxWith = new Box<int>(content);
                Console.WriteLine(boxWith.ToString());
            }
        }
    }
}
