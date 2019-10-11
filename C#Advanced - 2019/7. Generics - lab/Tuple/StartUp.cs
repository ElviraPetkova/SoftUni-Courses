using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];
            string town = firstInput[3];

            Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(name, address, town);

            string[] secondInput = Console.ReadLine().Split();
            string secondName = secondInput[0];
            int liters = int.Parse(secondInput[1]);
            bool drinkOrNot = secondInput[2]
                .ToLower() == "drunk" 
                ? true 
                : false;

            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(secondName, liters, drinkOrNot);

            string[] thirdInput = Console.ReadLine().Split();
            string thirdName = thirdInput[0];
            double doubleNumber = double.Parse(thirdInput[1]);
            string bankAccount = thirdInput[2];

            //Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(thirdName, doubleNumber, bankAccount);
            var thirdTuple = (Name: thirdName, Balance: doubleNumber, Account: bankAccount);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine($"{thirdTuple.Name} -> {thirdTuple.Balance} -> {thirdTuple.Account}");
        }
    }
}
