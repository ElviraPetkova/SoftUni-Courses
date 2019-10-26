namespace Rabbits
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Cage
    {
        private ICollection<Rabbit> data;

        public Cage(string name, int capacty)
        {
            this.Name = name;
            this.Capacity = capacty;
            this.data = new List<Rabbit>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count => this.data.Count();

        public void Add(Rabbit rabbit)
        {
            if(this.data.Count < this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            bool isExist = false;

            Rabbit rabbit = this.data.FirstOrDefault(x => x.Name == name);
            if(rabbit != null)
            {
                this.data.Remove(rabbit);
                isExist = true;
            }

            return isExist;
        }

        public void RemoveSpecies(string species)
        {
            this.data = this.data.Where(x => x.Species != species).ToList();           
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(x => x.Name == name);
            rabbit.Available = false;

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var rabbits = this.data.Where(x => x.Species == species).ToArray();
            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }

            return rabbits;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rabbit in this.data.Where(x=>x.Available == true))
            {
                stringBuilder.AppendLine(rabbit.ToString());
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
