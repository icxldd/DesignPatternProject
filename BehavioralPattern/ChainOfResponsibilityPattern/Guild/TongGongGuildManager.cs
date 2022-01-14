using System;

namespace ChainOfResponsibilityPattern.Guild
{
    public class TongGongGuildManager : AbsGuildManager
    {
        public TongGongGuildManager(string name, AbsGuildManager superiorGuildManager) : base(name,
            superiorGuildManager)
        {
        }

        public override void HandlerRequest(GuildRequest request)
        {
            if (request.GuildRequestType == GuildRequestType.改名称)
            {
                Console.WriteLine($"同工同意：{request.UserId}修改名字成功");
            }
            else
            {
                SuperiorGuildManager?.HandlerRequest(request);
            }
        }
    }
}