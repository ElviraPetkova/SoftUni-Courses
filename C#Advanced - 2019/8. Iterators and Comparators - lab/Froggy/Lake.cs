
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private List<T> stones;
        private List<T> startStones; // stones, even position => start with zero
        private List<T> endStones; // stones, odd position => reversed

        public Lake(params T[] elements)
        {
            this.stones = new List<T>(elements);
        }

        public IEnumerator<T> GetEnumerator()
        {
            this.startStones = new List<T>();
            this.endStones = new List<T>();

            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    this.startStones.Add(stones[i]);
                }
                else
                {
                    this.endStones.Add(stones[i]);
                }
            }

            this.endStones.Reverse();

            this.stones.Clear();
            this.stones.AddRange(this.startStones);
            this.stones.AddRange(this.endStones);

            for (int i = 0; i < this.stones.Count; i++)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
