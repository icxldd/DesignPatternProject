namespace VisitorPattern.Guild
{
    public abstract class AbsPlatform
    {
        public abstract string Accept(AbsVisitor absVisitor);
    }
}