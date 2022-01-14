using System;

namespace VisitorPattern.Guild.Domain
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public RegisterType RegisterType { get; set; }
        public DateTime CreateTime { get; set; }
        public int JoinGuildCount { get; set; }
    }
}