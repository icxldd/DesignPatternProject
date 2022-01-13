namespace CompositePattern.Organization
{
    public class GroupComposite : Composite
    {
        public GroupComposite(string name) : base(name, NodeType.Group)
        {
        }
    }
}