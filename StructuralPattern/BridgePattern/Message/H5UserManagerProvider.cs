using System;

namespace BridgePattern.Message
{
    public class H5UserManagerProvider : AbsUserManagerProvider
    {
        public override void SendMessage(Guid userId, string msg)
        {
            Console.WriteLine($"从H5向{userId.ToString()}发送消息:{msg}");
        }

        public override void TapeOut(Guid userId)
        {
            Console.WriteLine($"从H5把{userId.ToString()}踢下线");
        }
    }
}