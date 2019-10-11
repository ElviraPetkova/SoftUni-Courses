namespace Ferrari
{
    public class Ferrari : IDriveable
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Driver { get; private set; }

        public string Model { get; }

        public string PushGas()
        {
            return "Gas!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.UseBrakes()}/{this.PushGas()}/{this.Driver}";
        }
    }
}
