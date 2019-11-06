namespace ExplicitInterfaces.Models
{
    using Contracts;

    public class Citizen : IResident, IPerson
    {
        public Citizen()
        {              
        }

        public Citizen(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public string Country { get; }

        public int Age { get; }

        string IResident.GetName()
            => $"Mr/Ms/Mrs {this.Name}";

        string IPerson.GetName()
            => $"{this.Name}";

        
    }
}
