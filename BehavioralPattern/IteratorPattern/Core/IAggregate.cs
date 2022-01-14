namespace IteratorPattern.Core
{
    public interface IAggregate<TSource>
    {
        ITerator<TSource> GetIterator();
    }
}