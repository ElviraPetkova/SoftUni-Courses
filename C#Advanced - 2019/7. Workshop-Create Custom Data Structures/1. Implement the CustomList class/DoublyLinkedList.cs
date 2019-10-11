namespace _1._Implement_the_CustomList_class
{
    using System;
    using System.Collections.Generic;

    public class DoublyLinkedList<T>
    {
        private class ListNote
        {
            public T Value { get; set; }

            public ListNote(T value)
            {
                this.Value = value;
            }

            public ListNote NextNode { get; set; }

            public ListNote PreviousNode { get; set; }
        }
        private ListNote head;
        private ListNote tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if(this.Count == 0)
            {
                this.head = this.tail = new ListNote(element);
            }
            else
            {
                var newHead = new ListNote(element);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNote(element);
            }
            else
            {
                var newTail = new ListNote(element);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            T firstElement = this.head.Value;

            this.head = this.head.NextNode;
            if(this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;

            return firstElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            T lastElement = this.tail.Value;

            this.tail = this.tail.PreviousNode;
            if(tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;

            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            var currentNote = this.head;

            while (currentNote != null)
            {
                action(currentNote.Value);
                currentNote = currentNote.NextNode;
            }

        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;
            var currentNote = this.head;

            while (currentNote != null)
            {
                array[index] = currentNote.Value;
                currentNote = currentNote.NextNode;
                index++;
            }

            return array;
        }

        public List<T> ToList()
        {
            List<T> list = new List<T>();
            int index = 0;
            var currentNote = this.head;

            while (currentNote != null)
            {
                list[index] = currentNote.Value;
                currentNote = currentNote.NextNode;
                index++;
            }

            return list;
        }

    }
}
