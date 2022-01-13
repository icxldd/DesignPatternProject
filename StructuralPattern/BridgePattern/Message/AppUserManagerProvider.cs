using System;

namespace BridgePattern.Message
{
    public class AppUserManagerProvider : AbsUserManagerProvider
    {
        public override void SendMessage(Guid userId, string msg)
        {
            Console.WriteLine($"从APP向{userId.ToString()}发送消息:{msg}");
        }

        public override void TapeOut(Guid userId)
        {
            Console.WriteLine($"从APP把{userId.ToString()}踢下线");
        }
    }
}