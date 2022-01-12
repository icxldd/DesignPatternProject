using System;

namespace Builder.Core.Factory
{
    public class USAAppPlatformManager : AppPlatformManager
    {
        public override void SendUserMessage(Guid userId, string msg)
        {
            Console.WriteLine($"来自美国APP 发送消息：{userId},{msg}");
            this.MessageComplete(userId, msg);
            // base.SendUserMessage(userId, msg);
        }

        public USAAppPlatformManager(Action<Guid, string> messageComplete) : base(messageComplete)
        {
        }

        public USAAppPlatformManager()
        {
        }
    }
}