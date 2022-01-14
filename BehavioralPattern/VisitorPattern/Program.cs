using System;
using System.Linq;
using VisitorPattern.Guild;
using VisitorPattern.Guild.Domain;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var Users = ObjectBuilder.BuilderUsers(50).Select(x => { return new UserPlatform(x); }).Cast<AbsPlatform>()
                .ToList();
            var Guilds = ObjectBuilder.BuilderGuilds(50).Select(x => { return new GuildPlatform(x); })
                .Cast<AbsPlatform>().ToList();
            var GuildMembers = ObjectBuilder.BuilderGuildMembers(50).Select(x => { return new GuildMemberPlatform(x); })
                .Cast<AbsPlatform>()
                .ToList();
            var report = new BusinessReport(Users.Concat(Guilds).Concat(GuildMembers).ToList());

            // report.ShowReport(new PlatformAdminVisitor());
            // report.ShowReport(new GuildAdminVisitor());
            report.ShowReport(new GuildOwnerVisitor());

            Console.WriteLine("Hello World!");
        }
    }
}