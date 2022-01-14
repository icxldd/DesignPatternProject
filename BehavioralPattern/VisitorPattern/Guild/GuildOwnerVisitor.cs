using System;

namespace VisitorPattern.Guild
{
    public class GuildOwnerVisitor : AbsVisitor
    {
        public override string Visit(UserPlatform engineer)
        {
            return ($"目前是教会创始人，没有权限查看用户信息");
        }

        public override string Visit(GuildPlatform manager)
        {
            return($"目前是教会创始人，教会名：{manager._guild.Name},教会人数：{manager._guild.GuildMemberCount}");
        }

        public override string Visit(GuildMemberPlatform guildMemberPlatform)
        {
            return(
                $"目前是教会创始人，教会成员名：{guildMemberPlatform._guildMember.Name}，教会成员加入时间{guildMemberPlatform._guildMember.CreateTime.ToString("yyyy-M-d dddd")}");
        }
    }
}