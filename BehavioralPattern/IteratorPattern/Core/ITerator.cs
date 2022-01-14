namespace IteratorPattern.Core
{
    public interface ITerator<TSource>
    {
        TSource Current { get; }
        bool HasNext();
        void MoveNext();
    }
}