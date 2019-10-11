namespace Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const int WorkingDaysPerWeek = 5;

        private double weekSalary;
        private double workingHours;

        public Worker(string firstName, string lastName, double weekSalary, double workingHours) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        public double WeekSalary
        {
            get => this.weekSalary;

            protected set
            {
                if(value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double WorkingHours
        {
            get => this.workingHours;

            protected set
            {
                if(value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHours = value;
            }
        }

        public double SalaryPerHour => (this.WeekSalary / WorkingDaysPerWeek) / this.WorkingHours; 

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.workingHours:f2}")
                .Append($"Salary per hour: {this.SalaryPerHour:f2}");

            return stringBuilder.ToString();
        }
    }
}
