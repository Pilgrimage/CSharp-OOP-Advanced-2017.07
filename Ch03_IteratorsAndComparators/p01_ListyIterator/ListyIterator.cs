namespace p01_ListyIterator
{
    using System;
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private readonly List<T> myList;
        private int internalIndex;

        public ListyIterator(T[] list)
        {
            this.internalIndex = 0;
            this.myList = new List<T>(list);
        }

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
            if (this.myList.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            return this.myList[this.internalIndex];
        }
    }
}