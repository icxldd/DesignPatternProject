namespace CompositePattern.Organization
{
    public abstract class AbsComponent
    {
        protected string Name { get; }

        protected NodeType NodeType { get; }

        protected AbsComponent(string name, NodeType nodeType)
        {
            Name = name;
            NodeType = nodeType;
        }

        public abstract void Add(AbsComponent productComponent);

        public abstract void Remove(AbsComponent productComponent);

        public abstract void Display(int depth);
    }
}