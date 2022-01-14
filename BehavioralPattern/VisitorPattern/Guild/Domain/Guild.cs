using System;

namespace VisitorPattern.Guild.Domain
{
    public class Guild
    {
        public Guid GuildId { get; set; }
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }
        public int GuildMemberCount { get; set; }
    }
}