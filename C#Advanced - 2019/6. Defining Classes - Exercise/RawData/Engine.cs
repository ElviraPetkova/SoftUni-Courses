
namespace RawData
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        private int speed;
        private int power;

        public int Speed
        {
            get { return this.speed; }

            set { this.speed = value; }
        }

        public int Power
        {
            get { return this.power; }

            set { this.power = value; }
        }
    }
}
