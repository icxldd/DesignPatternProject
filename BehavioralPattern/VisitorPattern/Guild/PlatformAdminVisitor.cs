﻿using System;
using VisitorPattern.Guild.Domain;

namespace VisitorPattern.Guild
{
    public class PlatformAdminVisitor : AbsVisitor
    {
        public override void Visit(UserPlatform engineer)
        {
            string registerSource = engineer._user.RegisterType == RegisterType.App ? "APP" : "H5";
            Console.WriteLine(
                $"目前是平台管理员，{engineer._user.Name}加入{engineer._user.JoinGuildCount}个教会,注册来源为{registerSource}");
        }

        public override void Visit(GuildPlatform manager)
        {
            Console.WriteLine($"目前是平台管理员，教会名：{manager._guild.Name},教会人数：{manager._guild.GuildMemberCount}");
        }

        public override void Visit(GuildMemberPlatform guildMemberPlatform)
        {
            Console.WriteLine(
                $"目前是平台管理员，教会成员名：{guildMemberPlatform._guildMember.Name}，教会成员加入时间{guildMemberPlatform._guildMember.CreateTime.ToString("yyyy-M-d dddd")}");
        }
    }
}