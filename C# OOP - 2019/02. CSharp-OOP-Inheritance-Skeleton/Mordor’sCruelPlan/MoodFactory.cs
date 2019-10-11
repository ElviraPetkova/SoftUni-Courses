namespace MordorsCruelPlan
{
    using Moods;

    public class MoodFactory
    {
        public Mood GetMood(int happinesFood)
        {
            if (happinesFood < -5)
            {
                return new Angry();
            }
            else if (happinesFood >= -5 && happinesFood <= 0)
            {
                return new Sad();
            }
            else if (happinesFood >= 1 && happinesFood <= 15)
            {
               return  new Happy();
            }
            else if (happinesFood >= 16)
            {
                return new JavaScript();
            }
            else
            {
                return null;
            }
        }
    }
}
