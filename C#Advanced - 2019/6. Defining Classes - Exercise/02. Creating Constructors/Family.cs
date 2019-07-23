
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> listOfPeople;

        //public List<Person> ListOfPeople
        //{
        //    get { return this.listOfPeople; }

        //    set
        //    {
        //        this.listOfPeople = new List<Person>();
        //    }
        //}

        public Family()
        {
            this.listOfPeople = new List<Person>();
        }

        public void AddMember(Person person)
        {
            listOfPeople.Add(person);
        }

        public Person GetOldestMember()
        {
            int old = listOfPeople.Max(x=>x.Age);
            Person oldestPerson = listOfPeople
                .FirstOrDefault(x => x.Age == old);

            return oldestPerson;
        }
    }
}
