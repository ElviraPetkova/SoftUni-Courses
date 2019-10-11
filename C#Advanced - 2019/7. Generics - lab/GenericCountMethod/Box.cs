
using System.Collections.Generic;

namespace GenericCountMethod
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public List<T> Data => this.data;

        public void Add(T item)
        {
            this.data.Add(item);
        }
    }

}
