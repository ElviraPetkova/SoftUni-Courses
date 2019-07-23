
namespace RawData
{
    public class Tire
    {
        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        private int age;
        private double pressure;

        public int Age
        {
            get { return this.age; }

            set { this.age = value; }
        }

        public double Pressure
        {
            get { return this.pressure; }

            set { this.pressure = value; }
        }
    }
}
