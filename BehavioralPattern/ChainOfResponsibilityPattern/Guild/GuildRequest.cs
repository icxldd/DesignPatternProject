using System;

namespace ChainOfResponsibilityPattern.Guild
{
    public class GuildRequest
    {
        public Guid UserId { get; }
        public GuildRequestType GuildRequestType { get; }

        public GuildRequest(GuildRequestType guildRequestType, Guid userId)
        {
            GuildRequestType = guildRequestType;
            UserId = userId;
        }
    }
}