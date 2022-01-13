namespace CompositePattern.Classify
{
    public abstract class AbsProductComponent
    {
        protected string Name { get; }

        protected AbsProductComponent(string name)
        {
            Name = name;
        }

        public abstract void Add(AbsProductComponent productComponent);

        public abstract void Remove(AbsProductComponent productComponent);

        public abstract void Display(int depth);
    }
}