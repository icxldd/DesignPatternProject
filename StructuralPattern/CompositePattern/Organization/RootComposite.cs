namespace CompositePattern.Organization
{
    public class RootComposite : Composite
    {
        public RootComposite(string name) : base(name, NodeType.Root)
        {
        }
    }
}