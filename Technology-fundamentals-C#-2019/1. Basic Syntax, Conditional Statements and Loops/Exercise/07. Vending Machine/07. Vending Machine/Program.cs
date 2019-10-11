using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main()
        {
            string moneyOrCommand = Console.ReadLine();
            decimal totalMoney = 0M;
            decimal price = 0M;

            while (moneyOrCommand != "Start")
            {
                decimal money = decimal.Parse(moneyOrCommand);
                if (money == 0.1M || money == 0.2M || money == 0.5M || money == 1M || money == 2M)
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", money);
                }

                moneyOrCommand = Console.ReadLine();
            }

            string produckt = Console.ReadLine().ToLower();
            while (true)
            {
                if (produckt == "end")
                {
                    Console.WriteLine("Change: {0:f2}", totalMoney);
                    break;
                }
                else
                {
                    if (produckt == "nuts")
                    {
                        price = 2.0M;
                        if (totalMoney >= price)
                        {
                            totalMoney -= price;
                            Console.WriteLine("Purchased {0}", produckt);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (produckt == "water")
                    {
                        price = 0.70M;
                        if (totalMoney >= price)
                        {
                            totalMoney -= price;
                            Console.WriteLine("Purchased {0}", produckt);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (produckt == "crisps")
                    {
                        price = 1.50M;
                        if (totalMoney >= price)
                        {
                            totalMoney -= price;
                            Console.WriteLine("Purchased {0}", produckt);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (produckt == "soda")
                    {
                        price = 0.80M;
                        if (totalMoney >= price)
                        {
                            totalMoney -= price;
                            Console.WriteLine("Purchased {0}", produckt);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (produckt == "coke")
                    {
                        price = 1.00M;
                        if (totalMoney >= price)
                        {
                            totalMoney -= price;
                            Console.WriteLine("Purchased {0}", produckt);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }

                produckt = Console.ReadLine().ToLower();
            }
        }
    }
}
