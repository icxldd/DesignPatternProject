using System;

namespace Builder.Core.Factory
{
    public class USAH5PlatformManager : H5PlatformManager
    {
        public override void SendUserMessage(Guid userId, string msg)
        {
            Console.WriteLine($"来自美国H5发送消息：{userId},{msg}");
            base.SendUserMessage(userId, msg);
        }

        public USAH5PlatformManager(Action<Guid, string> messageComplete) : base(messageComplete)
        {
        }

        public USAH5PlatformManager()
        {
        }
    }
}