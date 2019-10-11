namespace Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;

            protected set
            {
                ValidationUpperCase(value, nameof(firstName));
                ValidationLenght(value, 3, nameof(firstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;

            protected set
            {
                ValidationUpperCase(value, nameof(lastName));
                ValidationLenght(value, 2, nameof(lastName));

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"First Name: {this.FirstName}")
                         .AppendLine($"Last Name: {this.LastName}");

            return stringBuilder.ToString();
        }

        private void ValidationLenght(string value, int lenght, string typeName)
        {
            if (value.Length <= lenght)
            {
                throw new ArgumentException($"Expected length at least {++lenght} symbols! Argument: {typeName}");
            }
        }

        private void ValidationUpperCase(string value, string typeName)
        {
            if (!char.IsUpper(value.First()))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {typeName}");
            }
        }
    }
}
