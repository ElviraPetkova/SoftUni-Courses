
using System;

namespace Repository
{
    public class Person
    {
        public Person(string name, int age, DateTime birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthday;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime Birthdate { get; set; }

        public override string ToString()
        {
            return $"{this.Name} is {this.Age} years old ({this.Birthdate:dd/MM/yyyy})";
        }
    }
}
