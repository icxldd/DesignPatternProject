using System;

namespace Builder.Core
{
    public class H5PlatformManager : AbsPlatformManager
    {
        public override void SendUserMessage(Guid userId, string msg)
        {
            Console.WriteLine($"H5发送消息：{userId},{msg}");
            base.SendUserMessage(userId, msg);
        }
        
        public H5PlatformManager(Action<Guid, string> messageComplete):base(messageComplete)
        {
        }

        public H5PlatformManager()
        {
        }
    }
}