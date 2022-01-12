using System;

namespace Builder.Core
{
    public class AppPlatformManager : AbsPlatformManager
    {
        public override void SendUserMessage(Guid userId, string msg)
        {
            Console.WriteLine($"App发送消息：{userId},{msg}");
            base.SendUserMessage(userId, msg);
        }
        public AppPlatformManager(Action<Guid, string> messageComplete):base(messageComplete)
        {
        }

        public AppPlatformManager()
        {
        }
    }
}