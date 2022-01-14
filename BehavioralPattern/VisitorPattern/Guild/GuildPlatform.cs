namespace VisitorPattern.Guild
{
    public class GuildPlatform : AbsPlatform
    {
        public Domain.Guild _guild;

        public GuildPlatform(Domain.Guild guild)
        {
            _guild = guild;
        }

        public override void Accept(AbsVisitor absVisitor)
        {
            absVisitor.Visit(this);
        }
    }
}