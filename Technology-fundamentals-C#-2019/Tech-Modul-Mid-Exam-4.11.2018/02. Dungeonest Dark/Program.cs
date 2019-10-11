using System;

namespace _02._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;

            string[] darkRomms = Console.ReadLine()
                .Split('|');

            bool isLife = true;

            for (int i = 0; i < darkRomms.Length; i++)
            {
                string[] info = darkRomms[i].Split();

                string item = info[0];
                int counter = int.Parse(info[1]);

                if(item == "potion")
                {
                    if(health + counter > 100)
                    {
                        int moreHealth = (health + counter) - 100;
                        counter -= moreHealth;
                    }

                    health += counter;

                    Console.WriteLine($"You healed for {counter} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if(item == "chest")
                {
                    coins += counter;

                    Console.WriteLine($"You found {counter} coins.");
                }
                else
                {
                    if(health - counter > 0)
                    {
                        health -= counter;

                        Console.WriteLine($"You slayed {item}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {item}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        isLife = false;
                        break;
                    }
                }
            }

            if (isLife)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
