namespace VisitorPattern.Guild
{
    public abstract class AbsPlatform
    {
        public abstract void Accept(AbsVisitor absVisitor);
    }
}