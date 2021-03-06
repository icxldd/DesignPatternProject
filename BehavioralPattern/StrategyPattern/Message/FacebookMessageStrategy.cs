using System;

namespace StrategyPattern.Message
{
    public class FacebookMessageStrategy : AbsMessageStrategy
    {
        public override void SendMessage(User user, string data)
        {
            Console.WriteLine($"从Facebook给{user.Name}发送消息：{data}");
        }
    }
}