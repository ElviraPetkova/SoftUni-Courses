using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var currentScale = new EqualityScale<string>("15", "15");
            string result = currentScale.AreEqual();
            PrintResult(result);
                   
            var secondScale = new EqualityScale<string>("Maria", "Gergana");
            string secondResult = secondScale.AreEqual();
            PrintResult(secondResult);

            var thirdScale = new EqualityScale<int>(25, 25);
            string thirdResult = thirdScale.AreEqual();
            PrintResult(thirdResult);
        }

        private static void PrintResult(string result)
        {
            if (result == "True")
            {
                Console.WriteLine("null");
            }
        }
    }
}
