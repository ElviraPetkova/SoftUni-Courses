namespace _1._Implement_the_CustomList_class
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] items;

        public CustomStack()
        {
            this.items = new T[InitialCapacity];
            this.Count = 0;
        }


        public int Count { get; private set; }

        private void Resize()
        {
            T[] nextItems = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                nextItems[i] = this.items[i];
            }

            this.items = nextItems;
        }

        public void Push(T element)
        {
            if(this.items.Length == this.Count)
            {
                this.Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            T lastElement = this.Peek();

            this.Count--;

            return lastElement;
        }

        public T Peek()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            int lastIndex = this.Count - 1;
            T lastElement = this.items[lastIndex];

            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
