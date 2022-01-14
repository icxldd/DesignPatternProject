using System;
using System.Collections;
using System.Collections.Generic;

namespace VisitorPattern.Guild.Domain
{
    public static class ObjectBuilder
    {
        public static IEnumerable<User> BuilderUsers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                User user = new User();
                user.Name = "自动生成" + i.ToString();
                user.CreateTime = DateTime.Now;
                user.UserId = Guid.NewGuid();
                user.JoinGuildCount = i;
                Random random = new Random();
                int type = random.Next(0, 2);
                user.RegisterType = Enum.Parse<RegisterType>(type.ToString());
                yield return user;
            }
        }

        public static IEnumerable<Guild> BuilderGuilds(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Guild guild = new Guild();
                guild.Name = "自动生成" + i.ToString();
                guild.CreateTime = DateTime.Now;
                guild.GuildId = Guid.NewGuid();
                guild.GuildMemberCount = i;

                yield return guild;
            }
        }


        public static IEnumerable<GuildMember> BuilderGuildMembers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                GuildMember guildMember = new GuildMember();
                guildMember.Name = "自动生成" + i.ToString();
                guildMember.CreateTime = DateTime.Now;
                guildMember.GuildId = Guid.NewGuid();
                guildMember.UserId = Guid.NewGuid();

                yield return guildMember;
            }
        }
    }
}