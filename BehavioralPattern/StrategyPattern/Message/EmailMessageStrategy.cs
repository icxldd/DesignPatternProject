using System;

namespace StrategyPattern.Message
{
    public class EmailMessageStrategy : AbsMessageStrategy
    {
        public override void SendMessage(User user, string data)
        {
            Console.WriteLine($"从邮箱给{user.Name}发送消息：{data}");
        }
    }
}