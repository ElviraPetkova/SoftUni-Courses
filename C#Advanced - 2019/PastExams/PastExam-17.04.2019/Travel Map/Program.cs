namespace Travel_Map
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var travelMap = new SortedDictionary<string, Dictionary<string, int>>();
            //key by sortedDictionary = country; value => key = town, value = price

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                //Bulgaria > Sofia > 500
                var information = input
                    .Split(new char[] { ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string country = information[0];
                string town = information[1];
                int price = int.Parse(information[2]);

                if (!travelMap.ContainsKey(country))
                {
                    travelMap.Add(country, new Dictionary<string, int>());
                }

                if (!travelMap[country].ContainsKey(town))
                {
                    travelMap[country].Add(town, price);
                }
                else
                {
                    if(travelMap[country][town] > price)
                    {
                        travelMap[country][town] = price;
                    }
                }
            }

            foreach (var contry in travelMap)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{contry.Key} ->");

                foreach (var town in contry.Value.OrderBy(x=>x.Value))
                {
                    stringBuilder.Append($" {town.Key} -> {town.Value}");
                }

                Console.WriteLine(stringBuilder.ToString());
            }
        }
    }
}
