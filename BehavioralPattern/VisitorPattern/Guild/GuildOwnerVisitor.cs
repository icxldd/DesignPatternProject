using System;

namespace VisitorPattern.Guild
{
    public class GuildOwnerVisitor : AbsVisitor
    {
        public override void Visit(UserPlatform engineer)
        {
            Console.WriteLine($"目前是教会创始人，没有权限查看用户信息");
        }

        public override void Visit(GuildPlatform manager)
        {
            Console.WriteLine($"目前是教会创始人，教会名：{manager._guild.Name},教会人数：{manager._guild.GuildMemberCount}");
        }

        public override void Visit(GuildMemberPlatform guildMemberPlatform)
        {
            Console.WriteLine(
                $"目前是教会创始人，教会成员名：{guildMemberPlatform._guildMember.Name}，教会成员加入时间{guildMemberPlatform._guildMember.CreateTime.ToString("yyyy-M-d dddd")}");
        }
    }
}