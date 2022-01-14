using System;
using ChainOfResponsibilityPattern.Guild;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new CreatorGuildManager("创建者", null);
            var admin = new AdminGuildManager("管理员", creator);
            var tongGong = new TongGongGuildManager("同工", admin);
            var request1 = new GuildRequest(GuildRequestType.关门,Guid.NewGuid());
            var request2 = new GuildRequest(GuildRequestType.改名称,Guid.NewGuid());
            var request3 = new GuildRequest(GuildRequestType.请假,Guid.NewGuid());
            
            tongGong.HandlerRequest(request1);
            tongGong.HandlerRequest(request2);
            tongGong.HandlerRequest(request3);
            
        }
    }
}