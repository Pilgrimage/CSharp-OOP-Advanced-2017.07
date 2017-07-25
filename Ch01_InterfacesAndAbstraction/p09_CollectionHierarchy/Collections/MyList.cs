namespace p09_CollectionHierarchy
{
    public class MyList<T> : Collection<T>, IMyList<T>
    {
        public int Add(T element)
        {
            this.List.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            T firstElement = this.List[0];
            this.List.RemoveAt(0);
            return firstElement;
        }

        public int Used
        {
            //get => this.List.Count;
            get { return this.List.Count; }
        }
    }
}
