namespace p08_CustomList
{
    using System;
    using System.Linq;

    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            var resultList = customList.Elements.OrderBy(x => x);
            return new CustomList<T>(resultList);
        }
    }
}
