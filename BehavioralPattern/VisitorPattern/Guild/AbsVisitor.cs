namespace VisitorPattern.Guild
{
    public abstract class AbsVisitor
    {
        public abstract void Visit(UserPlatform engineer);

        public abstract void Visit(GuildPlatform manager);

        public abstract void Visit(GuildMemberPlatform guildMemberPlatform);
    }
}