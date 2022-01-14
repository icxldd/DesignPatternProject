using System;

namespace VisitorPattern.Guild.Domain
{
    public class GuildMember
    {
        public Guid GuildId { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}