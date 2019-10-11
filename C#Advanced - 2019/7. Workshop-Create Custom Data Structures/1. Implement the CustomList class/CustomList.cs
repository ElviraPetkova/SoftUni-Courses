using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._Implement_the_CustomList_class
{
    public class CustomList<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;
        private T[] items;

        public CustomList()
        {
            this.items = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();

                }
                return items[index];
            }

            set
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public void Add(T item)
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public void AddRange(T[] values)
        {
            if(this.Count + values.Length >= this.items.Length)
            {
                this.Resize();
            }

            for (int i = 0; i < values.Length; i++)
            {
                this.items[this.Count] = values[i];
                Count++;
            }
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public T RemoveAt(int index)
        {
            if(index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);

            this.Count--;
            if(this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        public bool Remove(T element)
        {
            bool isRemoved = false;
            int indexOfElement = this.IndexOf(element);
            if(indexOfElement > -1)
            {
                isRemoved = true;
                this.items[indexOfElement] = default(T);
                this.Shift(indexOfElement);

                this.Count--;
                if (this.Count <= this.items.Length / 4)
                {
                    this.Shrink();
                }
            }

            return isRemoved;
        }

        public bool RemoveAll(T element)
        {
            bool isRemoved = false;
            int indexOfElement = this.IndexOf(element);
            while (indexOfElement != -1)
            {
                isRemoved = true;
                this.items[indexOfElement] = default(T);
                this.Shift(indexOfElement);

                this.Count--;
                if (this.Count <= this.items.Length / 4)
                {
                    this.Shrink();
                }

                indexOfElement = this.IndexOf(element);
            }
            
            return isRemoved;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i < index; i++)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        public void Insert(int index, T element)
        {
            if(index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if(this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = element;
            this.Count++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if(this.items[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i < Count; i++)
            {
                if (this.items[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
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
