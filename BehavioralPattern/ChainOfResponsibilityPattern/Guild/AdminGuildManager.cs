using System;

namespace ChainOfResponsibilityPattern.Guild
{
    public class AdminGuildManager : AbsGuildManager
    {
        public AdminGuildManager(string name, AbsGuildManager superiorGuildManager) : base(name,
            superiorGuildManager)
        {
        }

        public override void HandlerRequest(GuildRequest request)
        {
            if (request.GuildRequestType == GuildRequestType.请假)
            {
                Console.WriteLine($"管理员同意：{request.UserId}请假成功");
            }
            else
            {
                SuperiorGuildManager?.HandlerRequest(request);
            }
        }
    }
}