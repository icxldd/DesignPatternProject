using System;

namespace BridgePattern.Message
{
    public class WechatUserManagerProvider : AbsUserManagerProvider
    {
        public override void SendMessage(Guid userId, string msg)
        {
            Console.WriteLine($"从微信向{userId.ToString()}发送消息:{msg}");
        }

        public override void TapeOut(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}