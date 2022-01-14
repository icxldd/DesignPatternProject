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

        public override void Accept(AbsVisitor absVisitor)
        {
            absVisitor.Visit(this);
        }
    }
}