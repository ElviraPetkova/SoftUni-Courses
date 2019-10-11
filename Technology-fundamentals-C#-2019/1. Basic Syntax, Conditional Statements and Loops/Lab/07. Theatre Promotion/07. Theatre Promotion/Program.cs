using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;
            bool inValid = false;

            switch (typeOfDay)
            {
                case "Weekday":

                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    else
                    {
                        inValid = true;
                    }

                    break;
                case "Weekend":

                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    else
                    {
                        inValid = true;
                    }

                    break;
                case "Holiday":

                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        inValid = true;
                    }

                    break;
            }

            if (inValid)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine("{0}$", price);
            }
        }
    }
}
