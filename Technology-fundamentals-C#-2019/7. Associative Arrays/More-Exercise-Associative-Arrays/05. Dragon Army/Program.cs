using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var typeDragons = new Dictionary<string, List<Dragon>>();

            int defautDamage = 45;
            int defautHealth = 250;
            int defautArmor = 10;

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();
                //{type} {name} {damage} {health} {armor}
                string type = info[0];
                string name = info[1];
                string currentDamage = info[2];
                string currentHealth = info[3];
                string currentArmor = info[4];

                if(typeDragons.ContainsKey(type) == false)
                {
                    typeDragons[type] = new List<Dragon>();
                }

                int damage = SetValue(currentDamage, defautDamage);
                int health = SetValue(currentHealth, defautHealth);
                int armor = SetValue(currentArmor, defautArmor);

                if(typeDragons[type].Any(x=>x.Name == name) == false)
                {
                    Dragon newDragon = new Dragon(name, damage, health, armor);
                    typeDragons[type].Add(newDragon);
                }
                else
                {
                    int index = typeDragons[type].FindIndex(x => x.Name == name);
                    typeDragons[type][index].Health = health;
                    typeDragons[type][index].Damage = damage;
                    typeDragons[type][index].Armor = armor;
                }
            }

            foreach (var kvp in typeDragons)
            {
                string typeDragon = kvp.Key;
                double averangeDamage = kvp.Value.Average(x => x.Damage);
                double averangeHealth = kvp.Value.Average(x => x.Health);
                double averangeArmor = typeDragons[typeDragon].Average(x => x.Armor);

                Console.WriteLine($"{typeDragon}::({averangeDamage:f2}/{averangeHealth:f2}/{averangeArmor:f2})");

                foreach (var dragon in kvp.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }

            }
        }

        private static int SetValue(string currentValue, int defautValue)
        {
            int value = 0;
            if (currentValue == "null")
            {
                value = defautValue;
            }
            else
            {
                value = int.Parse(currentValue);
            }

            return value;
        }
    }
}
