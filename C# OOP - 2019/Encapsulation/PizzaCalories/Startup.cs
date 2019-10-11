namespace PizzaCalories
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split(" ");
                string[] doughInfo = Console.ReadLine().Split(" ");

                Pizza pizza = new Pizza(pizzaName[1]);
                //Dough dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
                pizza.Dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] input = command.Split(" ");
                    Topping topping = new Topping(input[1], int.Parse(input[2]));
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
