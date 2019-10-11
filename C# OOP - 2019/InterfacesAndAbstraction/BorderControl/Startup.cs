namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> all = new Dictionary<string, IBuyer>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = line[0];
                int age = int.Parse(line[1]);

                if (all.ContainsKey(name))
                {
                    continue;
                }

                if (line.Length == 4)
                {
                    string id = line[2];
                    string birthade = line[3];

                    IBuyer citzen = new Citizen(name, age, id, birthade);

                    all.Add(name, citzen);
                }
                else if (line.Length == 3)
                {
                    string group = line[2];

                    IBuyer rebel = new Rebel(name, age, group);

                    all.Add(name, rebel);
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string name = command;
                if(all.Any(x=>x.Key == name))
                {
                    all[name].BuyFood();
                }
            }

            Console.WriteLine(all.Select(x=>x.Value.Food).Sum());
        }

        
    }
}
