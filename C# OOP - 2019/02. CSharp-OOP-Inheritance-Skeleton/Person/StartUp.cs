﻿namespace Person
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            { 
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}