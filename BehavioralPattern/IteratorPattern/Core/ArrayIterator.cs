namespace IteratorPattern.Core
{
    public class ArrayIterator<TSource> : ITerator<TSource>
    {
        private TSource[] Sources;

        public ArrayIterator(TSource[] sources)
        {
            this.Sources = sources;
            this.index = 0;
        }

        private uint index;
        private TSource source;

        public TSource Current
        {
            get { return source; }
        }

        public bool HasNext()
        {
            return this.index < this.Sources.Length;
        }

        public void MoveNext()
        {
            this.source = this.Sources[index];
            this.index++;
        }
    }
}