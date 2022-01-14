using System;

namespace ChainOfResponsibilityPattern.Guild
{
    public class CreatorGuildManager : AbsGuildManager
    {
        public CreatorGuildManager(string name, AbsGuildManager superiorGuildManager) : base(name,
            superiorGuildManager)
        {
        }

        public override void HandlerRequest(GuildRequest request)
        {
            if (request.GuildRequestType == GuildRequestType.关门)
            {
                Console.WriteLine($"教会创始人同意：教会关门隐退");
            }
            else
            {
            }
        }
    }
}