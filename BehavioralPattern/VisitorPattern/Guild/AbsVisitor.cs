namespace VisitorPattern.Guild
{
    public abstract class AbsVisitor
    {
        public abstract string Visit(UserPlatform engineer);

        public abstract string Visit(GuildPlatform manager);

        public abstract string Visit(GuildMemberPlatform guildMemberPlatform);
    }
}