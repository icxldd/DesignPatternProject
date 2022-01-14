using System;

namespace VisitorPattern.Guild
{
    public class GuildAdminVisitor : AbsVisitor
    {
        public override string Visit(UserPlatform engineer)
        {
            return $"目前是教会管理员，没有权限查看用户信息";
        }

        public override string Visit(GuildPlatform manager)
        {
            return ($"目前是教会管理员，教会名：{manager._guild.Name}");
        }

        public override string Visit(GuildMemberPlatform guildMemberPlatform)
        {
            return ($"目前是教会管理员，教会成员名：{guildMemberPlatform._guildMember.Name}");
        }
    }
}