namespace p02_Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> myList;
        private int internalIndex;

        public ListyIterator(T[] list)
        {
            this.internalIndex = 0;
            this.myList = new List<T>(list);
        }

        public IReadOnlyList<T> MyList => this.myList ;

        public bool Move()
        {
            if (!this.HasNext())
            {
                return false;
            }
            this.internalIndex++;
            return true;
        }

        public bool HasNext()
        {
            return (this.internalIndex + 1) < this.myList.Count;
        }

        public T Print()
        {
            if (this.myList.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            return this.myList[this.internalIndex];
        }

        public string PrintAll()
        {
            if (this.myList.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            string result = "";
            foreach (T item in this.myList)
            {
                result = result + item.ToString() + " ";
            }
            return result.Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.myList.Count; i++)
            {
                yield return this.myList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}