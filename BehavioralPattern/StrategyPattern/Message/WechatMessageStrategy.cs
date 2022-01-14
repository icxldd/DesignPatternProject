using System;

namespace StrategyPattern.Message
{
    public class WechatMessageStrategy : AbsMessageStrategy
    {
        public override void SendMessage(User user, string data)
        {
            Console.WriteLine($"从微信给{user.Name}发送消息：{data}");
        }
    }
}