using System.Collections.Generic;

namespace p09_CollectionHierarchy
{
    public abstract class Collection<T>
    {
        private readonly IList<T> list;

        public Collection()
        {
            this.list = new List<T>();
        }

        public IList<T> List
        {
            //get => this.list;
            get { return this.list; }
        }
    }
}
