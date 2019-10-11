using System;

namespace _01._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double sablePrice = double.Parse(Console.ReadLine()); //all prices per one articul
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int counterOfSabes = countOfStudents + (int)Math.Ceiling(countOfStudents * 0.1);
            int countOfBelts = countOfStudents - (countOfStudents / 6);

            double neededMoney = (counterOfSabes * sablePrice) + (countOfStudents * robePrice) + (countOfBelts * beltPrice);

            if(money >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney - money):f2}lv more.");
            }
        }
    }
}
