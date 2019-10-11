
using System.Collections.Generic;
using System;
using System.Collections;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if(this.currentIndex < this.elements.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext() => this.currentIndex + 1 < this.elements.Count;

        public void Print()
        {
            if(this.elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(elements[currentIndex]);
        }

        public void PrintAll()
        {
            if(this.elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
