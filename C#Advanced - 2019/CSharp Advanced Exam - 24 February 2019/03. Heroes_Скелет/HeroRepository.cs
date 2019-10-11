using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Heroes
{
    public class HeroRepository
    {
        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count => data.Count;

        private List<Hero> data;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero currentHero = this.data.FirstOrDefault(x => x.Name == name);
            int heroIndex = this.data.IndexOf(currentHero);

            if(currentHero != null)
            {
                this.data.RemoveAt(heroIndex);
            }
            
        }

        public Hero GetHeroWithHighestStrength()
        {
            int bestStrenght = this.data.Max(x => x.Item.Strength);
            Hero currentHero = this.data.FirstOrDefault(x => x.Item.Strength == bestStrenght);

            return currentHero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            int bestAbility = this.data.Max(x => x.Item.Ability);
            Hero currentHero = this.data.FirstOrDefault(x => x.Item.Ability == bestAbility);

            return currentHero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int bestIntelligence = this.data.Max(x => x.Item.Intelligence);
            Hero currentHero = this.data.FirstOrDefault(x => x.Item.Intelligence == bestIntelligence);

            return currentHero;
        }

        public override string ToString()
        {
            var repositoryInfo = new StringBuilder();
            foreach (var item in this.data)
            {
                repositoryInfo.Append(item.ToString());
            }
            return repositoryInfo.ToString();
            //return $"{string.Join(Environment.NewLine, this.data)}";
        }
    }
}
