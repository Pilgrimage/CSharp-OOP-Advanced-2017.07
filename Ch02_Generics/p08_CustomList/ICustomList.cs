namespace p08_CustomList
{
    public interface ICustomList<T>
    {
        void Add(T element);

        T Remove(int ind);

        bool Contains(T element);

        void Swap(int ind1, int ind2);

        int CountGreaterThan(T element);

        T Max();

        T Min();
    }
}
