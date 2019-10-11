using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        private List<Astronaut> data;

        public void Add(Astronaut astronaut)
        {
            if(this.Capacity > this.data.Count)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut currentAstronaut = this.data.FirstOrDefault(x => x.Name == name);
            if (currentAstronaut != null)
            {
                int index = this.data.IndexOf(currentAstronaut);
                this.data.RemoveAt(index);

                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            int oldest = this.data.Max(x => x.Age);
            Astronaut oldestAstronaut = this.data.FirstOrDefault(x => x.Age == oldest);

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data.FirstOrDefault(x => x.Name == name);//if astronaut = null?

            return astronaut;
        }

        public string Report()
        {
            var reportingString = new StringBuilder();
            reportingString.AppendLine($"Astronauts working at Space Station {this.Name}:");

            for (int i = 0; i < this.data.Count; i++)
            {
                if(i == this.data.Count - 1)
                {
                    reportingString.Append(this.data[i]);
                }
                else
                {
                    reportingString.AppendLine(this.data[i].ToString());
                }
            }

            return reportingString.ToString();
        }
    }
}
