using System;
using System.Collections.Generic;

namespace _010._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> queueOfCars = new Queue<string>();

            bool isHitted = false;
            string hittedCarName = string.Empty;
            char hittedSymbol = '\0';
            int totalCars = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                if(input == "green")
                {
                    int currentGreenLight = greenLight;

                    while (currentGreenLight > 0 && queueOfCars.Count > 0)
                    {
                        string car = queueOfCars.Dequeue();
                        int carLenght = car.Length;

                        if(currentGreenLight - carLenght >= 0)
                        {
                            currentGreenLight -= carLenght;
                            totalCars++;
                        }
                        else // use freeWindow
                        {
                            currentGreenLight += freeWindow;

                            if(currentGreenLight - carLenght >= 0)
                            {
                                currentGreenLight -= carLenght;
                                totalCars++;
                                break;
                            }
                            else
                            {
                                isHitted = true;
                                hittedCarName = car;
                                hittedSymbol = car[currentGreenLight];
                                break;
                            }
                        }
                    }
                }
                else
                {
                    queueOfCars.Enqueue(input);
                }

                if (isHitted)
                {
                    break;
                }
            }

            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hittedCarName} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
