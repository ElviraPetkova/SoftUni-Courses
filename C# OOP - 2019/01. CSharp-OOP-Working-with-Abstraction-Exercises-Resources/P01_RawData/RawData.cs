namespace P01_RawData
{
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        private List<Car> cars;

        public RawData()
        {
            this.cars = new List<Car>();
        }

        public void Add(Car car) => this.cars.Add(car);

        public List<string> FilterCars(string command)
        {
            List<string> filterCars = new List<string>();

            if (command == "fragile")
            {
                filterCars = this.cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();               
            }
            else if(command == "flamable")
            {
                filterCars = this.cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();              
            }

            return filterCars;
        }
    }
}
