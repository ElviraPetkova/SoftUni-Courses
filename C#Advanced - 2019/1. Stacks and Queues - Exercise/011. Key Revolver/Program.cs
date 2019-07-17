using System;
using System.Collections.Generic;
using System.Linq;

namespace _011._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Queue<int> locks = new Queue<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse));                
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            int count = 0;
            int countOfBullets = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int oneBulet = bullets.Peek();
                int oneLock = locks.Peek();

                if(oneBulet <= oneLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                    count++;
                    countOfBullets++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    count++;
                    countOfBullets++;
                }

                if(count == sizeOfGunBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

            }

            if(locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int totalPrice = countOfBullets * priceOfBullet;
                int leftMoney = valueOfIntelligence - totalPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${leftMoney}");
            }
        }
    }
}
