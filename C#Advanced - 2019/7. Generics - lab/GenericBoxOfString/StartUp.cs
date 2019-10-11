using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string content = Console.ReadLine();
                Box<string> boxWith = new Box<string>(content);
                Console.WriteLine(boxWith.ToString());
            }
        }
    }
}
