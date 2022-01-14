using System;

namespace StrategyPattern.Message
{
    public class TwitterMessageStrategy : AbsMessageStrategy
    {
        public override void SendMessage(User user, string data)
        {
            Console.WriteLine($"从Twitter给{user.Name}发送消息：{data}");
        }
    }
}