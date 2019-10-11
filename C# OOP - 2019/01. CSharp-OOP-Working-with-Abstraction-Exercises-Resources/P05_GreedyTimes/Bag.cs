namespace P05_GreedyTimes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private List<Item> bag;
        private long capacity;
        private long current;

        public Bag(long capacity)
        {
            this.capacity = capacity;
            bag = new List<Item>();
        }

        public long GoldItemsValue
        {
            get => this.bag
                .Where(i => i is Gold)
                .Sum(i => i.Value);
        }

        public long CashItemsValue
        {
            get => this.bag
                .Where(i => i is Cash)
                .Sum(i => i.Value);
        }

        public long GemItemsValue
        {
            get => this.bag
                .Where(i => i is Gem)
                .Sum(i => i.Value);
        }

        public void AddGoldItem(Gold item)
        {
            if(this.capacity >= this.current + item.Value)
            {
                List<Item> goldItems = GetGoldItems();
                if(goldItems.Any(g=>g.Key == item.Key))
                {
                    goldItems.Single(g => g.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    this.bag.Add(item);
                }

                this.current += item.Value;
            }
        }

        public void AddGemItem(Gem item)
        {
            if(this.capacity >= this.current + item.Value && GoldItemsValue >= GemItemsValue + item.Value)
            {
                List<Item> gemItems = GetGemItems();
                if(gemItems.Any(g=>g.Key == item.Key))
                {
                    gemItems.Single(g => g.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    this.bag.Add(item);
                }

                current += item.Value;
            }
        }

        public void AddCashItem(Cash item)
        {
            if(this.capacity >= this.current + item.Value && GemItemsValue >= CashItemsValue + item.Value)
            {
                List<Item> cashItems = GetCashItems();
                if(cashItems.Any(c=>c.Key == item.Key))
                {
                    cashItems.Single(c => c.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    this.bag.Add(item);
                }

                current += item.Value;
            }
        }

        public List<Item> GetGoldItems() => this.bag
            .Where(i => i is Gold).ToList();

        public List<Item> GetGemItems() => this.bag
            .Where(i => i is Gem).ToList();

        public List<Item> GetCashItems() => this.bag
            .Where(c => c is Cash).ToList();

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            var dictionary = this.bag.GroupBy(i => i.GetType().Name).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var kvp in dictionary.OrderByDescending(kv => kv.Value.Sum(i => i.Value)))
            {
                if (kvp.Key == "Cash")
                {
                    builder.AppendLine($"<Cash> ${kvp.Value.Sum(i => i.Value)}");
                }
                else if (kvp.Key == "Gem")
                {
                    builder.AppendLine($"<Gem> ${kvp.Value.Sum(i => i.Value)}");
                }
                else if (kvp.Key == "Gold")
                {
                    builder.AppendLine($"<Gold> ${kvp.Value.Sum(i => i.Value)}");
                }

                foreach (var item in kvp.Value.OrderByDescending(i => i.Key).ThenBy(i => i.Value))
                {
                    builder.AppendLine($"##{item.Key} - {item.Value}");
                }
            }

            return builder.ToString().TrimEnd();
        }
    }
}
