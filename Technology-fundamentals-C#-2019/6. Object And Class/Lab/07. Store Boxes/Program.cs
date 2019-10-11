using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }

        public double PricePerItem { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public double PricePerBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> listOfBoxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                /* {Serial Number} {Item Name} {Item Quantity} {itemPrice}
                The Price of one box has to be calculated: itemQuantity * itemPrice. */

                string[] info = input.Split();
                string serialNumber = info[0];
                string itemName = info[1];
                int itemQuantity = int.Parse(info[2]);
                double itemPrice = double.Parse(info[3]);

                double priceForBox = itemQuantity * itemPrice;

                Item newItem = new Item()
                {
                    Name = itemName,
                    PricePerItem = itemPrice
                };

                Box oneBox = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = newItem,
                    Quantity = itemQuantity,
                    PricePerBox = priceForBox
                };

                listOfBoxes.Add(oneBox);
            }

            foreach (Box oneBox in listOfBoxes.OrderByDescending(b=>b.PricePerBox))
            {
                Console.WriteLine(oneBox.SerialNumber);
                Console.WriteLine($"-- {oneBox.Item.Name} - ${oneBox.Item.PricePerItem:f2}: {oneBox.Quantity}");
                Console.WriteLine($"-- ${oneBox.PricePerBox:f2}");
            }
        }
    }
}
