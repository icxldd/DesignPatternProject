namespace IteratorPattern.Core
{
    public class ArrayAggregate<TSource> : IAggregate<TSource>
    {
        private TSource[] Sources;

        public ArrayAggregate(TSource[] sources)
        {
            this.Sources = sources;
        }

        public ITerator<TSource> GetIterator()
        {
            return new ArrayIterator<TSource>(Sources);
        }
    }
}