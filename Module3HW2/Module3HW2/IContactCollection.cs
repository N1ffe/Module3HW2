namespace Module3HW2
{
    public interface IContactCollection<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        void Add(V item);
        void Delete(V item);
    }
}
