using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            var stones = Console.ReadLine()
                .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake<int> lake = new Lake<int>(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
