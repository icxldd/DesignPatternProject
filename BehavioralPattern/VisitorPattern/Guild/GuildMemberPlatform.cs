using VisitorPattern.Guild.Domain;

namespace VisitorPattern.Guild
{
    public class GuildMemberPlatform : AbsPlatform
    {
        public GuildMember _guildMember;

        public GuildMemberPlatform(GuildMember guildMember)
        {
            _guildMember = guildMember;
        }

        public override string Accept(AbsVisitor absVisitor)
        {
            return absVisitor.Visit(this);
        }
    }
}