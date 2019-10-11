using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Person
    {
        public Person(string name, int money, List<Product> bag)
        {
            this.Name = name;
            this.Money = money;

            BagOfProducts = new List<Product>();
        }

        public Person() { }

        public string Name { get; set; }

        public int Money { get; set; } 

        public List<Product> BagOfProducts { get; set; }

    }

    class Product
    {
        public Product(string name, int cost)
        {
            this.NameOfProduct = name;
            this.Cost = cost;
        }

        public Product() { }

        public string NameOfProduct { get; set; }

        public int Cost { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleAndMoney = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsAndCost = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < peopleAndMoney.Length; i++)
            {
                string[] info = peopleAndMoney[i].Split('=');
                string name = info[0];
                int money = int.Parse(info[1]);

                Person onePerson = new Person(name, money, new List<Product>());
                people.Add(onePerson);
            }

            for (int i = 0; i < productsAndCost.Length; i++)
            {
                string[] info = productsAndCost[i].Split('=');
                string name = info[0];
                int cost = int.Parse(info[1]);

                Product oneProduct = new Product(name, cost);
                products.Add(oneProduct);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] tokens = input.Split();

                string personName = tokens[0];
                string productName = tokens[1];

                Person searchPerson = GetPerson(people, personName);
                Product searchProduct = GetProduct(products, productName);

                if (searchPerson.Money < searchProduct.Cost)
                {
                    Console.WriteLine($"{searchPerson.Name} can't afford {searchProduct.NameOfProduct}");
                    continue;
                }

                AddProductInBag(people, searchPerson, searchProduct);
                Console.WriteLine($"{personName} bought {productName}");
            }

            foreach (var person in people)
            {
                if(person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.Write($"{person.Name} - ");

                    for (int i = 0; i < person.BagOfProducts.Count; i++)
                    {
                        Console.Write($"{person.BagOfProducts[i].NameOfProduct}");

                        if(i < person.BagOfProducts.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }

                    Console.WriteLine();
                }
            }

        }

        private static void AddProductInBag(List<Person> people, Person searchPerson, Product searchProduct)
        {
            foreach (var person in people)
            {
                if (person.Name == searchPerson.Name)
                {
                    person.BagOfProducts.Add(new Product(searchProduct.NameOfProduct, 1));
                    person.Money -= searchProduct.Cost;
                }
            }
        }

        private static Product GetProduct(List<Product> products, string productName)
        {
            Product searchProduct = new Product();
            foreach (var product in products)
            {
                if(product.NameOfProduct == productName)
                {
                    searchProduct.NameOfProduct = product.NameOfProduct;
                    searchProduct.Cost = product.Cost;
                    break;
                }
            }
            return searchProduct;
        }

        static Person GetPerson(List<Person> peoples, string nameOfPerson)
        {
            Person searhPerson = new Person();
            foreach (var person in peoples)
            {
                if(person.Name == nameOfPerson)
                {
                    searhPerson.Name = person.Name;
                    searhPerson.Money = person.Money;
                    break;
                }
            }
            return searhPerson;
        }
    }
}
