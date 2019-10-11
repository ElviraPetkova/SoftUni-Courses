
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CreateCustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex = -1;

        public CustomStack()
        {
            this.elements = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                this.elements.Insert(++currentIndex, item);
            }
        }

        public T Pop()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T lastElement = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);
            currentIndex--;

            return lastElement;

        }

        public void Print()
        {
            if(this.elements.Count > 0)
            {
                var printStack = this.elements.ToArray().Reverse().ToList();
                Console.WriteLine(string.Join(Environment.NewLine, printStack));
                Console.WriteLine(string.Join(Environment.NewLine, printStack));
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}
