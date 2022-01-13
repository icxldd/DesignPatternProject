namespace CompositePattern.Organization
{
    public class DepartmentComposite : Composite
    {
        public DepartmentComposite(string name) : base(name, NodeType.Department)
        {
        }
    }
}