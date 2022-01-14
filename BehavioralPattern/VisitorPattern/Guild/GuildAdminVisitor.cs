using System;

namespace VisitorPattern.Guild
{
    public class GuildAdminVisitor : AbsVisitor
    {
        public override void Visit(UserPlatform engineer)
        {
            Console.WriteLine($"目前是教会管理员，没有权限查看用户信息");
        }

        public override void Visit(GuildPlatform manager)
        {
            Console.WriteLine($"目前是教会管理员，教会名：{manager._guild.Name}");
        }

        public override void Visit(GuildMemberPlatform guildMemberPlatform)
        {
            Console.WriteLine($"目前是教会管理员，教会成员名：{guildMemberPlatform._guildMember.Name}");
        }
    }
}