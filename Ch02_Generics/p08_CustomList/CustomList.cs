namespace p08_CustomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly IList<T> elements;

        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
        }

        public IList<T> Elements
        {
            get { return this.elements; }
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            T removedElement = this.elements[index];
            this.elements.RemoveAt(index);
            return removedElement;
        }

        public bool Contains(T element)
        {
            return this.elements.Contains(element);
        }

        public void Swap(int ind1, int ind2)
        {
            T tempElement = this.elements[ind1];
            this.elements[ind1] = this.elements[ind2];
            this.elements[ind2] = tempElement;
        }

        public int CountGreaterThan(T element)
        {
            return this.elements.Count(e => e.CompareTo(element) > 0);
        }
        
        public T Max()
        {
            return this.elements.Max();
        }

        public T Min()
        {
            return this.elements.Min();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
