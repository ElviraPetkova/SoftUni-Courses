using System.Collections.Generic;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public int Count => this.gladiators.Count;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }


        public void Remove(string name)
        {
            Gladiator currentGladiator = this.gladiators.FirstOrDefault(g => g.Name == name);
            int index = this.gladiators.IndexOf(currentGladiator);

            if(currentGladiator != null)
            {
                this.gladiators.RemoveAt(index);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            int maxStatPower = this.gladiators.Max(x => x.GetStatPower());
            var gladiator = this.gladiators.FirstOrDefault(x => x.GetStatPower() == maxStatPower);

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            int maxWeaponPower = this.gladiators.Max(x => x.GetWeaponPower());
            var gladiator = this.gladiators.FirstOrDefault(x => x.GetWeaponPower() == maxWeaponPower);

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            int maxTotalPower = this.gladiators.Max(x => x.GetTotalPower());
            var gladiator = this.gladiators.FirstOrDefault(x => x.GetTotalPower() == maxTotalPower);

            return gladiator;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}
