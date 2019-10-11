using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class Repository
    {
        public Repository()
        {
            this.data = new Dictionary<int, Person>();
            this.id = 0;
        }

        private Dictionary<int, Person> data;
        private int id;

        public int Count => this.data.Count;

        public void Add(Person person)
        {
            this.data.Add(id++, person);
        }

        public Person Get(int identificator)
        {
            return this.data.FirstOrDefault(x => x.Key == identificator).Value;
        }

        public bool Delete(int identificator)
        {
            if (this.data.ContainsKey(identificator))
            {
                data.Remove(identificator);
                return true;
            }

            return false;
        }

        public bool Update(int identificator, Person newPerson)
        {
            if (this.data.ContainsKey(identificator))
            {
                this.data[identificator] = newPerson;
                return true;
            }

            return false;
        }
    }
}
